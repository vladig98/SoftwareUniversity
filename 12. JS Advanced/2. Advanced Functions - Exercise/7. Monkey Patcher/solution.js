function solution(command) {
    const obfuscationThreshold = 50;

    function obfuscateVotes(upvotes, downvotes) {
        const greaterVotes = Math.max(upvotes, downvotes);
        const obfuscationAmount = Math.ceil(0.25 * greaterVotes);
        return {
            upvotes: upvotes + obfuscationAmount,
            downvotes: downvotes + obfuscationAmount
        };
    }

    function calculateRating(upvotes, downvotes) {
        const totalVotes = upvotes + downvotes;

        if (totalVotes < 10) {
            return 'new';
        }

        const positivePercentage = (upvotes / totalVotes) * 100;

        if (positivePercentage > 66) {
            return 'hot';
        } else if (totalVotes >= 100 && upvotes >= downvotes) {
            return 'controversial';
        } else if (downvotes > upvotes) {
            return 'unpopular';
        }

        return 'new';
    }

    if (command === 'upvote') {
        this.upvotes++;
    } else if (command === 'downvote') {
        this.downvotes++;
    } else if (command === 'score') {
        let reportedUpvotes = this.upvotes;
        let reportedDownvotes = this.downvotes;

        if (this.upvotes + this.downvotes > obfuscationThreshold) {
            const obfuscatedVotes = obfuscateVotes(this.upvotes, this.downvotes);
            reportedUpvotes = obfuscatedVotes.upvotes;
            reportedDownvotes = obfuscatedVotes.downvotes;
        }

        return [reportedUpvotes, reportedDownvotes, this.upvotes - this.downvotes, calculateRating(this.upvotes, this.downvotes)];
    }
}