function solve() {

    let departButton = document.getElementById('depart');
    let arriveButton = document.getElementById('arrive');
    let info = document.getElementsByClassName('info')[0];

    let currentId = 'depot'
    let name = ''

    function depart() {
        fetch(`https://judgetests.firebaseio.com/schedule/${currentId}.json`)
            .then(r => r.json())
            .then(d => {
                info.innerHTML = `Next stop ${d.name}`
                name = d.name;
                currentId = d.next;
                departButton.disabled = true;
                arriveButton.disabled = false;
            })
            .catch(() =>{
                info.innerHTML = 'Error';
                departButton.disabled = true;
                arriveButton.disabled = true;
            }) 
    }

    function arrive() {
                info.innerHTML = `Arriving at ${name}`
                departButton.disabled = false;
                arriveButton.disabled = true;
            
    }

    return {
        depart,
        arrive
    };
}

let result = solve();