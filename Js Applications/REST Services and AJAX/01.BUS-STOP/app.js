function getInfo() {

    let stopId = document.getElementById('stopId').value;
    let stopName = document.getElementById('stopName');
    let buses = document.getElementById('buses');

    stopName.innerHTML = '';
    buses.innerHTML = '';

    fetch(`https://judgetests.firebaseio.com/businfo/${stopId}.json`)
        .then(r => r.json())
        .then(x => {
            stopName.innerHTML = x.name;

            console.log(Object.entries(x.buses)
                .forEach(([id, time]) => {

                    let li = document.createElement('li');
                    li.innerHTML = `Bus ${id} arrives in ${time}`
                    buses.appendChild(li)

                })
            )
        })
        .catch(() => stopName.innerHTML = 'Error')

}

