function attachEvents() {

    let author = document.getElementById('author')
    let content = document.getElementById('content')
    let messages = document.getElementById('messages')

    let submit = document.getElementById('submit')
    let refresh = document.getElementById('refresh')

    const url = `https://rest-messanger.firebaseio.com/messanger.json`

    submit.addEventListener('click', send)

    refresh.addEventListener('click', refreshFunc)

    function refreshFunc(){

        if (messages.innerHTML !== '') {
            messages.innerHTML = '';
        }
        fetch(url)
        .then(r => r.json())
        .then(data => {
            Object.entries(data).forEach(([id, info]) => {

                let { author, content } = info;

                messages.innerHTML += `${author}: ${content}\n`
            })
        })
        .catch(() => console.error('Error'))
    }

    function send() {

        if (author.value !== '' && content.value !== '') {

            let obj = {
                author: author.value,
                content: content.value,
            };
            const headers = {
                method: 'POST',
                headers: {
                    'Content-type': 'application/json'
                },
                body: JSON.stringify(obj)
            }
            fetch(url, headers)
                .then(() => {
                    author.value = '';
                    content.value = '';
                })
                .catch(() => console.error('Error'))
        }

    }
}

attachEvents();