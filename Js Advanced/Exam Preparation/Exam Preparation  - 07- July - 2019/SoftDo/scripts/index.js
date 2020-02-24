function mySolution() {
    let send = document.getElementsByTagName('button')[0];
    let textarea = document.getElementsByTagName('textarea')[0];

    let pendingQuestions = document.getElementById('pendingQuestions')
    let openQuestions = document.getElementById('openQuestions')

    let temp = '';

    send.addEventListener('click', () => {

        if (textarea.value === '') {
            return;
        }

        let username = document.querySelector("#inputSection > div > input[type=username]").value;
        let div = document.createElement('div');
        div.classList.add('pendingQuestion');

        let img = document.createElement('img')
        img.src = "./images/user.png";
        img.width = "32";
        img.height = "32";
        div.appendChild(img);

        let span = document.createElement('span')

        if (username === '') {

            username = 'Anonymous'
            span.innerHTML = username

        }
        span.innerHTML = username
        div.appendChild(span);

        let p = document.createElement('p');
        p.innerHTML = textarea.value;
        div.appendChild(p)

        let divButton = document.createElement('div');
        divButton.classList.add('actions')

        let archiveButton = document.createElement('button');
        archiveButton.classList.add('archive')
        archiveButton.innerHTML = 'Archive';
        divButton.appendChild(archiveButton)

        let openButton = document.createElement('button');
        openButton.classList.add('open')
        openButton.innerHTML = 'Open';
        divButton.appendChild(openButton)

        div.appendChild(divButton)
        pendingQuestions.appendChild(div)
        temp = textarea.value
        textarea.value = '';

        archiveButton.addEventListener('click', () => {

            pendingQuestions.removeChild(div)

        })

        openButton.addEventListener('click', (e) => {

            e.target.parentElement.parentElement.remove()

            let div = document.createElement('div')
            div.classList.add("openQuestion")

            let img = document.createElement('img');
            img.src = "./images/user.png";
            img.width = "32";
            img.height = "32";
            div.appendChild(img)

            let span = document.createElement('span')

            if (username === '') {

                username = 'Anonymous'
                span.innerHTML = username
            }
            span.innerHTML = username;
            div.appendChild(span);

            let p = document.createElement('p');
            p.innerHTML = temp;
            div.appendChild(p);

            let divActions = document.createElement('div');
            divActions.classList.add('actions');

            let replyButton = document.createElement('button');
            replyButton.classList.add('reply');
            replyButton.innerHTML = 'Reply';

            let inputReply = document.createElement('input');
            inputReply.classList.add('replyInput');
            inputReply.type = 'text';
            inputReply.placeholder = 'Reply to this question here';

            let sendReplyButton = document.createElement('button');
            sendReplyButton.classList.add('replyButton');
            sendReplyButton.innerHTML = 'Send';

            let ol = document.createElement('ol');
            ol.classList.add('reply');
            ol.type = '1';
            divActions.appendChild(replyButton);
            div.appendChild(divActions);


            replyButton.addEventListener('click', () => {

                if (replyButton.innerHTML === 'Reply') {
                    replyButton.innerHTML = 'Back';
                    divReplySection.style.display = 'block'
                } else {
                    replyButton.innerHTML = 'Reply';
                    divReplySection.style.display = 'none'
                }
                divReplySection.appendChild(inputReply);
                divReplySection.appendChild(sendReplyButton);
                divReplySection.appendChild(ol)

            })

            let divReplySection = document.createElement('div');
            divReplySection.classList.add('replySection');
            divReplySection.style = 'disply: none;'

            sendReplyButton.addEventListener('click', () => {

                if (inputReply.value !== '') {
                    let li = document.createElement('li');
                    li.innerHTML = inputReply.value;
                    ol.appendChild(li);
                    divReplySection.appendChild(ol);
                    inputReply.value = '';
                }

            });

            div.appendChild(divReplySection);

            openQuestions.appendChild(div);
        });

    });
}
