    class Article {

        constructor(title, creator) {

            this.title = title;
            this.creator = creator;
            this._comments = [];
            this._likes = [];
        }
        get likes() {

            if (this._likes.length === 0) {
                return `${this.title} has 0 likes`
            }
            if (this._likes.length === 1) {
                return `${this._likes[0]} likes this article!`
            } 
                return `${this._likes[0]} and ${this._likes.length - 1} others like this article!`
            
        }
        like(username) {
            let liker = this._likes.includes(username)

            if (liker) {
                throw new Error("You can't like the same article twice!");
            }
            if (username === this.creator) {
                throw new Error("You can't like your own articles!")
            }
            this._likes.push(username);
            return `${username} liked ${this.title}!`
        }
        dislike(username) {

            if (this._likes[0] !== username) {
                throw new Error("You can't dislike this article!")
            }
            let index = this._likes.indexOf(username);
            this._likes.splice(index, 1)
            return `${username} disliked ${this.title}`
        }
        comment(username, content, id) {

            if (id === undefined || !(this._comments.find(x => x.Id === id))) {
                let currComment = {
                    Id: this._comments.length + 1,
                    Username: username,
                    Content: content,
                    Replies: []
                }
                this._comments.push(currComment);
                return `${username} commented on ${this.title}`
            } else {
                let comment = this._comments.find(x => x.Id === id)

                let currId = Object.keys(comment.Replies).length;


                let reply = {
                    Id: `${id}.${currId === 0 ? 1 : currId + 1}`,
                    Username: username,
                    Content: content
                }
                reply.Id +this.CountIDReply;
                comment.Replies.push(reply)
                return "You replied successfully"
            }

        }
        toString(sortingType) {

            let output = '';
            output += `Title: ${this.title}\n`
            output += `Creator: ${this.creator}\n`
            output += `Likes: ${this._likes.length}\n`
            output += `Comments:\n`
            if (sortingType === 'username') {
                
                for (const comment of this._comments.sort((a, b) => {
                    if (a.Username < b.Username) {
                        return -1;
                    }
                    if (a.Username > b.Username) {
                        return 1;
                    }
                    return 0;
                })) {
                    output += `-- ${comment.Id}. ${comment.Username}: ${comment.Content}\n`
                    for (const reply of comment.Replies.sort((a, b) => {
                        if (a.Username < b.Username) {
                            return -1;
                        }
                        if (a.Username > b.Username) {
                            return 1;
                        }
                        return 0;
                    })) {
                        output += `--- ${reply.Id}. ${reply.Username}: ${reply.Content}\n`
                    }

                }

            }
            if (sortingType === 'desc') {
                for (const comment of this._comments.sort((a, b) => {
                    if (a.Username < b.Username) {
                        return -1;
                    }
                    if (a.Username > b.Username) {
                        return 1;
                    }
                    return 0;
                })) {
                    output += `-- ${comment.Id}. ${comment.Username}: ${comment.Content}\n`
                    for (const reply of comment.Replies.sort((a, b) => {
                        if (a.Id < b.Id) {
                            return -1;
                        }
                        if (a.Id > b.Id) {
                            return 1;
                        }
                        return 0;
                    })) {
                        output += `--- ${reply.Id}. ${reply.Username}: ${reply.Content}\n`
                    }
                }

            }
            if (sortingType === 'asc') {
                for (const comment of this._comments.sort((a, b) => {
                    if (a.Username < b.Username) {
                        return -1;
                    }
                    if (a.Username > b.Username) {
                        return 1;
                    }
                    return 0;
                })) {
                    output += `-- ${comment.Id}. ${comment.Username}: ${comment.Content}\n`
                    for (const reply of comment.Replies.sort((a, b) => {
                        if (a.Id < b.Id) {
                            return -1;
                        }
                        if (a.Id > b.Id) {
                            return 1;
                        }
                        return 0;
                    })) {
                        output += `--- ${reply.Id}. ${reply.Username}: ${reply.Content}\n`
                    }
                }

            }
            return output


        }
    }

    let art = new Article("My Article", "Anny");
    art.like("John");
    console.log(art.likes);
    art.dislike("John");
    console.log(art.likes);
    art.comment("Sammy", "Some Content");
    console.log(art.comment("Ammy", "New Content"));
    art.comment("Zane", "Reply", 1);
    art.comment("Jessy", "Nice :)");
    console.log(art.comment("SAmmy", "Reply@", 1));
    console.log()
    console.log(art.toString('username'));
    console.log()
    art.like("Zane");
    console.log(art.toString('desc'));