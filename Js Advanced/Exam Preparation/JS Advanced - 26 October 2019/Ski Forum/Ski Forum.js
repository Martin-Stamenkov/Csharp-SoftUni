class Forum {
    constructor() {
        this._users = [];
        this._questions = [];
        this._id = 1;
    }

    register(username, password, repeatPassword, email) {

        let user = this._users.find(u => u.username === username);

        if (username === '' || password === '' || repeatPassword === '' || email === '') {

            throw new Error("Input can not be empty");
        }

        if (password !== repeatPassword) {
            throw new Error("Passwords do not match");
        }

        if (user) {
            throw new Error("This user already exists!")
        }

        let registeredUser = { username, password, email, login: false }
        this._users.push(registeredUser);
        return `${username} with ${email} was registered successfully!`

    }
    login(username, password) {
        let user = this._users.find(u => u.username === username);

        if (!user) {
            throw new Error("There is no such user");
        }

        if (user.password === password) {
            user.login = true;
            return "Hello! You have logged in successfully";
        }
    }
    logout(username, password) {
        let user = this._users.find(u => u.username === username);

        if (!user) {
            throw new Error("There is no such user");
        }

        if (user.password === password) {
            user.login = false;
            return "You have logged out successfully";
        }
    }
    postQuestion(username, question) {
        let user = this._users.find(u => u.username === username);

        if (!user || user.login === false) {
            throw new Error("You should be logged in to post questions");
        }

        if (question === '') {
            throw new Error("Invalid question");
        }
        let currentQuestion = {
            username: username,
            id: this._id++,
            question: question,
            answers: []
        }
        this._questions.push(currentQuestion);
        return "Your question has been posted successfully";
    }
    postAnswer(username, questionId, answer) {
        let user = this._users.find(u => u.username === username);
        let question = this._questions.find(q => q.id === questionId)

        if (!user || user.login === false) {

            throw new Error("You should be logged in to post answers");
        }
        if (answer === '') {

            throw new Error("Invalid answer")
        }
        if (!question) {

            throw new Error("There is no such question");
        }
        let currentAnswer = {
            username: username,
            answer: answer
        }
        question.answers.push(currentAnswer)

        return "Your answer has been posted successfully";
    }
    showQuestions() {
        let output = '';

        for (const question of this._questions) {
            output += `Question ${question.id} by ${question.username}: ${question.question}\n`

            for (const answer of question.answers) {
                output += `---${answer.username}: ${answer.answer}\n`
            }
        }
        return output.trim();
    }
}

let forum = new Forum();

forum.register('Michael', '123', '123', 'michael@abv.bg');
console.log(forum.register('Stoyan', '123ab7', '123ab7', 'some@gmail@.com'));
forum.login('Michael', '123');
console.log(forum.login('Stoyan', '123ab7'));

forum.postQuestion('Michael', "Can I rent a snowboard from your shop?");
forum.postAnswer('Stoyan', 1, "Yes, I have rented one last year.");
forum.postQuestion('Stoyan', "How long are supposed to be the ski for my daughter?");
forum.postAnswer('Michael', 2, "How old is she?");
forum.postAnswer('Michael', 2, "Tell us how tall she is.");

console.log(forum.showQuestions());