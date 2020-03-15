function attachEvents() {

    const url = 'https://phonebook-nakov.firebaseio.com/phonebook.json';

    let loadBtn = document.getElementById("btnLoad")
    let btnCreate = document.getElementById("btnCreate")
    let phonebookData = document.getElementById("phonebook")

    loadBtn.addEventListener('click', loadContacts)
    btnCreate.addEventListener('click', createContact)

    function createContact() {
        let person = document.getElementById("person").value
        let phone = document.getElementById("phone").value

        if (person === '' || phone === '') {
            return
        }
        const headers = {
            method: 'POST',
            headers: {
                'Content-type': 'application/json'
            },
            body: JSON.stringify({
                person, phone
            })
        }
        fetch(url, headers)
            .then(() => {
                document.getElementById("person").value = '';
                document.getElementById("phone").value = '';
                phonebookData.innerHTML = '';
                loadContacts()
            })
            .catch(() => console.error('Error'))
    }
    function loadContacts() {

        if (phonebookData.innerHTML !== '') {
            return;
        }

        fetch(url)
            .then(x => x.json())
            .then(el => {
                Object.entries(el).forEach(([contactId, phonebook]) => {
                    let { phone, person } = phonebook;

                    let li = document.createElement('li');
                    li.innerHTML = `${person}: ${phone} `

                    let deletBtn = document.createElement('button');
                    deletBtn.innerHTML = 'Delete';
                    deletBtn.setAttribute('currentId', contactId)
                    deletBtn.addEventListener('click', deleteContact);
                    li.appendChild(deletBtn);
                    phonebookData.appendChild(li)
                });
            })
            .catch(() => console.error('Error'))
    }
    function deleteContact() {

        let id = this.getAttribute('currentId');
        const headers = {
            method: 'DELETE'
        };
        fetch(`https://phonebook-nakov.firebaseio.com/phonebook/${id}.json`, headers)
            .then(() => {
                phonebookData.innerHTML = '';
                loadContacts();
            })
            .catch(() => console.error('Error'))
    }
}
attachEvents();
