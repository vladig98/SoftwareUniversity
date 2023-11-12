$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs')

        this.get('#/', function () {
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/home/home.hbs')
            })
        })

        this.get('#/home', function () {
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/home/home.hbs')
            })
        })

        this.get('#/about', function () {
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/about/about.hbs')
            })
        })

        this.get('#/login', function () {
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                loginForm: './templates/login/loginForm.hbs'
            }).then(function () {
                this.partial('./templates/login/loginPage.hbs')
            })
        })

        this.get('#/register', function () {
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                registerForm: './templates/register/registerForm.hbs'
            }).then(function () {
                this.partial('./templates/register/registerPage.hbs')
            })
        })

        this.post('#/register', function (context) {
            let that = this;
            let { username, password, repeatPassword } = context.params

            auth.register(username, password, repeatPassword)
                .then(function (res) {
                    auth.saveSession(res);
                    auth.showInfo('Registered Successfully')
                    that.redirect('#/')
                })
        })

        this.post('#/login', function (context) {
            let that = this;
            let { username, password } = context.params

            auth.login(username, password)
                .then(function (res) {
                    auth.saveSession(res);
                    auth.showInfo('Logged in Successfully')
                    that.redirect('#/')
                })
        })

        this.get('#/logout', function () {
            let result = auth.logout()
            sessionStorage.clear()
            auth.showInfo('Successfully logged out!')
            this.redirect('#/')
        })

        this.get('#/catalog', async function () {
            this.hasNoTeam = sessionStorage.getItem('teamId') == 'undefined'
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')

            await teamsService.loadTeams().then((res) => {
                this.teams = res
            })

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                team: './templates/catalog/team.hbs'
            }).then(function () {
                this.partial('./templates/catalog/teamCatalog.hbs')
            })
        })

        this.get('#/catalog/:id', async function () {
            this.hasNoTeam = sessionStorage.getItem('teamId') == 'undefined'
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')

            await teamsService.loadTeamDetails(this.params['id'].split(':')[1]).then((res) => {
                this.name = res.name;
                this.comment = res.comment
                this.isAuthor = res._acl.creator == sessionStorage.getItem('userId')
                this.isOnTeam = sessionStorage.getItem('teamId') == this.params['id'].split(':')[1]
                this.teamId = this.params['id'].split(':')[1]
            })

            await requester.get('user', '', 'kinvey').then((res) => {
                this.members = res.filter(x => x.teamId == this.params['id'].split(':')[1])
            })

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                teamControls: './templates/catalog/teamControls.hbs',
                teamMember: './templates/catalog/teamMember.hbs'
            }).then(function () {
                this.partial('./templates/catalog/details.hbs')
            })
        })

        this.get('#/edit/:id', function () {
            this.hasNoTeam = sessionStorage.getItem('teamId') == 'undefined'
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')
            this.teamId = this.params['id'].split(':')[1]

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                editForm: './templates/edit/editForm.hbs'
            }).then(function () {
                this.partial('./templates/edit/editPage.hbs')
            })
        })

        this.post('#/edit/:id', function (context) {
            let that = this;
            let { name, comment } = context.params

            teamsService.edit(this.params['id'].split(':')[1], name, comment)
                .then(function (res) {
                    auth.showInfo('Updated successfully!')
                    that.redirect('#/catalog')
                })
        })

        this.get('#/join/:id', function () {
            if (sessionStorage.getItem('teamId') != "" && sessionStorage.getItem('teamId') != 'undefined' && sessionStorage.getItem('teamId') != undefined) {
                return;
            }

            teamsService.joinTeam(this.params['id'].split(":")[1])
            sessionStorage.setItem('teamId', this.params['id'].split(":")[1])

            this.redirect('#/catalog')
        })

        this.get('#/leave', function () {
            this.hasNoTeam = sessionStorage.getItem('teamId') == 'undefined'
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')

            teamsService.leaveTeam()
            sessionStorage.setItem('teamId', '')

            this.redirect('#/catalog')
        })

        this.get('#/create', function () {
            this.hasNoTeam = !!sessionStorage.getItem('teamId')
            this.loggedIn = !!sessionStorage.getItem('authtoken')
            this.username = sessionStorage.getItem('username')

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                createForm: './templates/create/createForm.hbs'
            }).then(function () {
                this.partial('./templates/create/createPage.hbs')
            })
        })

        this.post('#/create', function (context) {
            let that = this;
            let { name, comment } = context.params

            teamsService.createTeam(name, comment)
                .then(function (res) {
                    teamsService.joinTeam(res._id)
                    auth.showInfo('Team created Successfully')
                    that.redirect('#/catalog')
                })
        })
    });

    app.run('#/');
});