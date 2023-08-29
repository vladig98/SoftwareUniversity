
# **Упражнения: Прости проверки**
Задачи за упражнение в клас и за домашно към курса [„Основи на програмирането“ @ СофтУни](https://softuni.bg/courses/programming-basics).
0. ## **Празно Visual Studio решение (Blank Solution)**
Създайте празно решение (**Blank Solution**) във Visual Studio за да организирате решенията на задачите от упражненията – всяка задача ще бъде в отделен проект и всички проекти ще бъдат в общ solution.

1. Стартирайте Visual Studio.
1. Създайте нов **Blank Solution**: [File]à [New] à [Project].

1. Изберете от диалоговия прозорец [Templates] à [Other Project Types] à [Visual Studio Solutions] à [**Blank Solution**] и дайте подходящо име на проекта, например “**Simple-Conditions**”:

Сега имате създаден **празен Visual Studio Solution** (без проекти в него):

Целта на този **blank solution** e да добавяте в него **по един проект за всяка задача** от упражненията.
0. ## **Проверка за отлична оценка**
Първата задача от тази тема е да се напише **конзолна програма**, която **въвежда оценка** (десетично число) и отпечатва “**Excellent!**”, ако оценката е **5.50** или по-висока.

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1">6</td><td colspan="1">Excellent!</td><td colspan="1">5</td><td colspan="1"><i>(няма изход)</i></td><td colspan="1">5\.50</td><td colspan="1">Excellent!</td><td colspan="1">5\.49</td><td colspan="1"><i>(няма изход)</i></td></tr>
</table>

1. Създайте **нов проект** в съществуващото Visual Studio решение. В Solution Explorer кликнете с десен бутон на мишката върху **Solution 'Simple-Conditions'**. Изберете [Add] à [New Project…]:

1. Ще се отвори диалогов прозорец за избор на тип проект за създаване. Изберете C# конзолно приложение и задайте име “**Excellent-Result**”:

Вече имате solution с едно конзолно приложение в него. Остава да напишете кода за решаване на задачата.

1. Отидете в тялото на метода **Main(string[]** **args)** и напишете решението на задачата. Можете да си помогнете с кода от картинката по-долу:

1. **Стартирайте** програмата с [Ctrl+F5] и я **тествайте** с различни входни стойности:



1. **Тествайте** решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/152#0>. Трябва да получите **100 точки** (напълно коректно решение):


0. ## **Отлична оценка или не**
Следващата задача от тази тема е да се напише **конзолна програма**, която **въвежда оценка** (десетично число) и отпечатва “**Excellent!**”, ако оценката е **5.50** или по-висока, или “**Not excellent.**” в противен случай.

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1">6</td><td colspan="1">Excellent!</td><td colspan="1">5</td><td colspan="1">Not excellent.</td><td colspan="1">5\.50</td><td colspan="1">Excellent!</td><td colspan="1">5\.49</td><td colspan="1">Not excellent.</td></tr>
</table>

1. Първо създайте **нов C# конзолен проект** в решението “**Simple-Conditions**”.

   0. Кликнете с мишката върху решението в Solution Explorer и изберете [Add] à [**New Project**…].
   0. Изберете [Visual C#] à [Windows] à [**Console Application**] и задайте име “**Excellent-or-Not**”.
1. **Напишете кода** на програмата. Може да си помогнете с примерния код от картинката:

1. Включете режим на **автоматично превключване към текущия проект** като кликнете върху главния solution с десния бутон на мишката и изберете **[Set StartUp Projects…]**:

Ще се появи диалогов прозорец, от който трябва да се избере **[Startup Project]** à [**Current selection**]:

1. Сега **стартирайте програмата**, както обикновено с [Ctrl+F5] и я тествайте:



1. Тествайте в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#1>. Решението би трябвало да бъде прието като напълно коректно:

0. ## **Четно или нечетно**
Да се напише програма, която въвежда **цяло число** и печата дали е **четно** или **нечетно**. Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1">2</td><td colspan="1">even</td><td colspan="1">3</td><td colspan="1">odd</td><td colspan="1">25</td><td colspan="1">even</td><td colspan="1">1024</td><td colspan="1">odd</td></tr>
</table>

1. Първо добавете **нов C# конзолен проект** в съществуващия solution.
1. **Напишете кода** на програмата. Проверката за четност може да се реализира чрез проверка на **остатъка при деление на 2** по следния начин: **var even = (num % 2 == 0)**.
1. **Стартирайте** програмата с **[Ctrl+F5]** и я тествайте:

1. Тествайте в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#2>.
0. ## **Намиране на по-голямото число**
Да се напише програма, която въвежда **две цели числа** и отпечатва по-голямото от двете. Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top"><p>5</p><p>3</p></td><td colspan="1" valign="top">5</td><td colspan="1" valign="top"><p>3</p><p>5</p></td><td colspan="1" valign="top">5</td><td colspan="1" valign="top"><p>10</p><p>10</p></td><td colspan="1" valign="top">10</td><td colspan="1" valign="top"><p>-5</p><p>5</p></td><td colspan="1" valign="top">5</td></tr>
</table>

1. Първо добавете **нов C# конзолен проект** в съществуващия solution.
1. **Напишете кода** на програмата. Необходима е единична **if**-**else** конструкция.
1. **Стартирайте** програмата с **[Ctrl+F5]** и я тествайте:

1. Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#3>.

**Подсказка**: може да си помогнете частично с кода от картинката, който е нарочно замъглен, за да помислите как да си го напишете сами:

0. ## **Изписване на число до 10 с думи**
Да се напише програма, която въвежда **цяло число в диапазона [0…10]** и го **изписва с думи** на английски език. Ако числото е извън диапазона, изписва “**number too big**”. Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top">5</td><td colspan="1" valign="top">five</td><td colspan="1" valign="top">1</td><td colspan="1" valign="top">one</td><td colspan="1" valign="top">9</td><td colspan="1" valign="top">nine</td><td colspan="1" valign="top">10</td><td colspan="1" valign="top">number too big</td></tr>
</table>

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#4>.

**Подсказка**: можете да напишете дълга **if**-**else**-**if**-**else**…**else**, с която да разгледате възможните **11 случая**.
0. ## **Бонус точки**
Дадено е **цяло число** – брой точки. Върху него се начисляват **бонус точки** по правилата, описани по-долу. Да се напише програма, която пресмята **бонус точките** за това число и **общия брой точки** с бонусите.

- Ако числото е **до 100** включително, бонус точките са **5**.
- Ако числото е **по-голямо от 100**, бонус точките са **20%** от числото.
- Ако числото е **по-голямо от 1000**, бонус точките са **10%** от числото.
- Допълнителни бонус точки (начисляват се отделно от предходните):
  - За **четно** число à + 1 т.
  - За число, което **завършва на 5** à + 2 т.

Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top">20</td><td colspan="1" valign="top"><p>6</p><p>26</p></td><td colspan="1" valign="top">175</td><td colspan="1" valign="top"><p>37</p><p>212</p></td><td colspan="1" valign="top">2703</td><td colspan="1" valign="top"><p>270\.3</p><p>2973\.3</p></td><td colspan="1" valign="top">15875</td><td colspan="1" valign="top"><p>1589\.5</p><p>17464\.5</p></td></tr>
</table>

Ето как би могло да изглежда решението на задачата в действие:

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#5>.

**Подсказка**:

- Основните бонус точки можете да изчислите с **if**-**else**-**if**-**else**-**if** конструкция (имате 3 случая).
- Допълнителните бонус точки можете да изчислите с **if**-**else**-**if** конструкция (имате още 2 случая).
0. ## **Сумиране на секунди**
Трима спортни състезатели финишират за някакъв **брой секунди** (между **1** и **50**). Да се напише програма, която въвежда времената на състезателите и пресмята **сумарното им време** във формат "**минути:секунди**". Секундите да се изведат с **водеща нула** (2 à "02", 7 à "07", 35 à "35"). Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top"><p>35</p><p>45</p><p>44</p></td><td colspan="1" valign="top">2:04</td><td colspan="1" valign="top"><p>22</p><p>7</p><p>34</p></td><td colspan="1" valign="top">1:03</td><td colspan="1" valign="top"><p>50</p><p>50</p><p>49</p></td><td colspan="1" valign="top">2:29</td><td colspan="1" valign="top"><p>14</p><p>12</p><p>10</p></td><td colspan="1" valign="top">0:36</td></tr>
</table>

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#6>.

**Подсказка**:

- Сумирайте трите числа и получете резултата в секунди. Понеже **1 минута = 60 секунди**, ще трябва да изчислите броя минути и броя секунди в диапазона от 0 до 59.
- Ако резултатът е между 0 и 59, отпечатайте 0 минути + изчислените секунди.
- Ако резултатът е между 60 и 119, отпечатайте 1 минута + изчислените секунди минус 60.
- Ако резултатът е между 120 и 179, отпечатайте 2 минути + изчислените секунди минус 120.
- Ако секундите са по-малко от 10, изведете водеща нула преди тях.
0. ## **Конвертор за мерни единици**
Да се напише програма, която **преобразува разстояние** между следните 8 **мерни единици**: **m**, **mm**, **cm**, **mi**, **in**, **km**, **ft**, **yd**. Използвайте съответствията от таблицата по-долу:

|**входна единица**|**изходна единица**|
| :-: | :-: |
|**1** meter (**m**)|**1000** millimeters (**mm**)|
|**1** meter (**m**)|**100** centimeters (**cm**)|
|**1** meter (**m**)|**0.000621371192** miles (**mi**)|
|**1** meter (**m**)|**39.3700787** inches (**in**)|
|**1** meter (**m**)|**0.001** kilometers (**km**)|
|**1** meter (**m**)|**3.2808399** feet (**ft**)|
|**1** meter (**m**)|**1.0936133** yards (**yd**)|

Входните данни се състоят от три реда:

- Първи ред: число за преобразуване
- Втори ред: входна мерна единица
- Трети ред: изходна мерна единица (за резултата)

Примерен вход и изход:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top"><p>12</p><p>km</p><p>ft</p></td><td colspan="1" valign="top">39370\.0788 ft</td><td colspan="1" valign="top">150 mi in</td><td colspan="1" valign="top">9503999\.99393599 mi</td><td colspan="1" valign="top"><p>450</p><p>yd</p><p>km</p></td><td colspan="1" valign="top">0\.41147999937455 yd</td></tr>
</table>

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#7>.
0. ## **Познай паролата**
Да се напише програма, която **въвежда парола** (един ред с произволен текст) и проверява дали въведеното **съвпада** с фразата “**s3cr3t!P@ssw0rd**”.** При съвпадение да се изведе “**Welcome**”. При несъвпадение да се изведе “**Wrong password!**”. Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top">qwerty</td><td colspan="1" valign="top">Wrong password!</td><td colspan="1" valign="top">s3cr3t!P@ssw0rd</td><td colspan="1" valign="top">Welcome</td><td colspan="1" valign="top">s3cr3t!p@ss</td><td colspan="1" valign="top">Wrong password!</td></tr>
</table>

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#8>.

**Подсказка**: използвайте **if**-**else** конструкцията.
0. ## **Число от 100 до 200**
Да се напише програма, която **въвежда цяло число** и проверява дали е **под 100**, **между 100 и 200** или **над 200**. Да се отпечатат съответно съобщения като в примерите по-долу:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top">95</td><td colspan="1" valign="top">Less than 100</td><td colspan="1" valign="top">120</td><td colspan="1" valign="top">Between 100 and 200</td><td colspan="1" valign="top">210</td><td colspan="1" valign="top">Greater than 200</td></tr>
</table>

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#9>.

**Подсказка**: използвайте **if**-**else**-**if**-**else** конструкция за да проверите всеки от трите случая.
0. ## **Еднакви думи**
Да се напише програма, която **въвежда две думи** и проверява дали са еднакви. Да не се прави разлика между главни и малки думи. Да се изведе “**yes**” или “**no**”. Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top"><p>Hello</p><p>Hello</p></td><td colspan="1" valign="top">yes</td><td colspan="1" valign="top"><p>SoftUni</p><p>softuni</p></td><td colspan="1" valign="top">yes</td><td colspan="1" valign="top"><p>Soft</p><p>Uni</p></td><td colspan="1" valign="top">no</td><td colspan="1" valign="top"><p>beer</p><p>vodka</p></td><td colspan="1" valign="top">no</td><td colspan="1" valign="top"><p>HeLlO</p><p>hELLo</p></td><td colspan="1" valign="top">yes</td></tr>
</table>

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#10>.

**Подсказка**: използвайте **if**-**else** конструкция. Преди сравняване на думите ги обърнете в долен регистър: **word = word.ToLower()**.
0. ## **Информация за скоростта**
Да се напише програма, която **въвежда скорост** (десетично число)** и отпечатва **информация за скоростта**. При скорост **до 10** (включително) отпечатайте “**slow**”. При скорост **над 10** и **до 50** отпечатайте “**average**”. При скорост **над 50** и **до 150** отпечатайте “**fast**”. При скорост **над 150** и **до 1000** отпечатайте “**ultra fast**”. При по-висока скорост отпечатайте “**extremely fast**”. Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top">8</td><td colspan="1" valign="top">slow</td><td colspan="1" valign="top">49\.5</td><td colspan="1" valign="top">average</td><td colspan="1" valign="top">126</td><td colspan="1" valign="top">fast</td><td colspan="1" valign="top">160</td><td colspan="1" valign="top">ultra fast</td><td colspan="1" valign="top">3500</td><td colspan="1" valign="top">extremely fast</td></tr>
</table>

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#11>.

**Подсказка**: използвайте серия от **if**-**else**-**if**-**else-**… конструкции, за да хванете всичките 5 случая.
0. ## **Лица на фигури**
Да се напише програма, която **въвежда размерите на геометрична** фигура и пресмята лицето й. Фигурите са четири вида: квадрат (**square**), правоъгълник (**rectangle**), кръг (**circle**) и триъгълник (**triangle**). На първия ред на входа се чете вида на фигурата (**square**, **rectangle**, **circle** или **triangle**). Ако фигурата е **квадрат**, на следващия ред се чете едно число – дължина на страната му. Ако фигурата е **правоъгълник**, на следващите два реда четат две числа – дължините на страните му. Ако фигурата е **кръг**, на следващия ред чете едно число – радиусът на кръга. Ако фигурата е **триъгълник**, на следващите два реда четат две числа – дължината на страната му и дължината на височината към нея. Резултатът да се закръгли до **3 цифри след десетичната точка**. Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top"><p>square</p><p>5</p></td><td colspan="1" valign="top">25</td><td colspan="1" valign="top"><p>rectangle</p><p>7</p><p>2\.5</p></td><td colspan="1" valign="top">17\.5</td><td colspan="1" valign="top"><p>circle</p><p>6</p></td><td colspan="1" valign="top">113\.097</td><td colspan="1" valign="top"><p>triangle</p><p>4\.5</p><p>20</p></td><td colspan="1" valign="top">45</td></tr>
</table>

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#12>.

**Подсказка**: използвайте серия от **if**-**else**-**if**-**else-**… конструкции, за да обработите 4-те вида фигури.
0. ## **Време + 15 минути**
Да се напише програма, която **въвежда час и минути** от 24-часово денонощие и изчислява колко ще е **часът след 15 минути**. Резултатът да се отпечата във формат **hh:mm**. Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59. Часовете се изписват с една или две цифри. Минутите се изписват винаги с по две цифри, с **водеща нула** когато е необходимо. Примери:

<table><tr><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th><th colspan="1" rowspan="2" valign="top"></th><th colspan="1"><b>вход</b></th><th colspan="1"><b>изход</b></th></tr>
<tr><td colspan="1" valign="top"><p>1</p><p>46</p></td><td colspan="1" valign="top">2:01</td><td colspan="1" valign="top"><p>0</p><p>01</p></td><td colspan="1" valign="top">0:16</td><td colspan="1" valign="top"><p>23</p><p>59</p></td><td colspan="1" valign="top">0:14</td><td colspan="1" valign="top"><p>11</p><p>08</p></td><td colspan="1" valign="top">11:23</td><td colspan="1" valign="top"><p>12</p><p>49</p></td><td colspan="1" valign="top">13:04</td></tr>
</table>

Тествайте решението си в **judge системата**: <https://judge.softuni.bg/Contests/Practice/Index/151#13>.

**Подсказка**: добавете 15 минути и направете няколко проверки. Ако минутите надвишат 59, увеличете часовете с 1 и намалете минутите със 60. По аналогичен начин разгледайте случая, когато часовете надвишат 23. При печатането на минутите проверете за водеща нула.
0. ## **Еднакви 3 числа**
Три еднакви числа: да се въведат 3 числа и да се отпечата дали са еднакви (yes / no).
0. ## **\*Изписване на число до 100 с думи**
Да се напише програма, която превръща число [0…100] в текст: 25 à “twenty five”
# **Упражнения: Графични и Web приложения**
0. ## **Графично приложение: конвертор за валути**
Създайте графично (**GUI**) приложение за **конвертиране на валути**. Приложението трябва да изглежда приблизително като на картинката по-долу:

1. Създайте нов **Windows Forms Application** с име “**Currency-Converter**”:

1. **Наредете контролите** във формата: една кутийка за въвеждане на число (**NumericUpDown**), един падащ списък с валути (**ComboBox**), текстов блок за резултата (**Label**) и няколко надписа (**Label**). Нагласете **размерите** и свойствата им, за да изглеждат долу-горе като на картинката:

1. Задайте следните препоръчителни **настройки на контролите**:

За **главната форма** (**Form**), която съдържа всички контроли:

- (name) = **FormConverter**
- **Text** = "**Currency Converter**"
- **Font.Size** = **12**
- **MaximizeBox** = **False**
- **MinimizeBox** = **False**
- **FormBorderStyle** = **FixedSingle**

За **полето за въвеждане на число** (**NumericUpDown**):

- (name) = **numericUpDownAmount**
- **Value** = **1**
- **Minimum** = **0**
- **Maximum** = **1000000**
- **TextAlign** = **Right**
- **DecimalPlaces** = **2**

За **падащия списък в валутите** (**ComboBox**):

- (name) = **comboBoxCurrency**
- **DropDownStyle** = **DropDownList**
- **Items** = 
  - **EUR**
  - **USD**
  - **GBP**

За **текстовия блок за резултата** (**Label**):

- (name) = **labelResult**
- **AutoSize** = **False**
- **BackColor** = **PaleGreen**
- **TextAlign** = **MiddleCenter**
- **Font.Size** = **14**
- **Font.Bold** = **True**
1. Хванете следните **събития**, за да напишете C# кода, който ще се изпълни при настъпването им:
- Събитието **ValueChanged** на контролата за въвеждане на число **numericUpDownAmount**:

- Събитието **Load** на формата **FormConverter**.
- Събитието **SelectedIndexChanged** на падащия списък за избор на валута **comboBoxCurrency**. 
1. Напишете следния **C# код** за обработка на събитията:

|<p>private void FormConverter\_Load(object sender, EventArgs e)</p><p>{</p><p>`   `this.comboBoxCurrency.SelectedItem = "EUR";</p><p>}</p><p></p><p>private void numericUpDownAmount\_ValueChanged(object sender, EventArgs e)</p><p>{</p><p>`   `ConvertCurrency();</p><p>}</p><p></p><p>private void comboBoxCurrency\_SelectedIndexChanged(object sender, EventArgs e)</p><p>{</p><p>`   `ConvertCurrency();</p><p>}</p>|
| :- |

Задачата на горния код е да избере при стартиране на програмата валута “**EUR**” и при промяна на стойностите в полето за сума или при смяна на валутата да изчисли резултата, извиквайки **ConvertCurrency()**.

1. Следва да се напише действието **ConvertCurrency()** за конвертиране на въведената сума от лева в избраната валута: 

|<p>private void ConvertCurrency()</p><p>{</p><p>`    `var originalAmount = this.numericUpDownAmount.Value;</p><p>`    `var convertedAmount = originalAmount;</p><p>`    `if (this.comboBoxCurrency.SelectedItem.ToString() == "EUR")</p><p>`    `{</p><p>`        `convertedAmount = originalAmount / 1.95583m;</p><p>`    `}</p><p>`    `else if (this.comboBoxCurrency.SelectedItem.ToString() == "USD")</p><p>`    `{</p><p>`        `convertedAmount = originalAmount / 1.80810m;</p><p>`    `}</p><p>`    `else if (this.comboBoxCurrency.SelectedItem.ToString() == "GBP")</p><p>`    `{</p><p>`        `convertedAmount = originalAmount / 2.54990m;</p><p>`    `}</p><p>`    `this.labelResult.Text = originalAmount + " лв. = " +</p><p>`        `Math.Round(convertedAmount, 2) + " " + this.comboBoxCurrency.SelectedItem;</p><p>}</p>|
| :- |

Горният код взима **сумата** за конвертиране от полето **numericUpDownAmount** и **избраната валута** за резултата от полето **comboBoxCurrency**. След това с **условна конструкция** според избраната валута, сумата се дели на **валутния курс** (който е фиксиран твърдо в сорс кода). Накрая се генерира текстово **съобщение с резултата** (закръглен до 2 цифри след десетичната точка) и се записва в зелената кутийка **labelResult**.

