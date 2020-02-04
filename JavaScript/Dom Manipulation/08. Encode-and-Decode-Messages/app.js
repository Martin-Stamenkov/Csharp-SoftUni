function encodeAndDecodeMessages() {

    let encodeButton = document.getElementsByTagName('button')[0]
    let decodeButton = document.getElementsByTagName('button')[1]

    let input = document.getElementsByTagName('textarea')[0]
    let output = document.getElementsByTagName('textarea')[1]

    let message = '';
    encodeButton.addEventListener('click', () => {


        for (let i = 0; i < input.value.length; i++) {
            message += String.fromCharCode(input.value[i]
                .charCodeAt(input.value[i]) + 1)

        }
        input.value = ''
        output.innerHTML = message;
        message = '';
    })
    decodeButton.addEventListener('click', () => {
        for (let i = 0; i < output.value.length; i++) {
            message += String.fromCharCode(output.value[i]
                .charCodeAt(output.value[i]) - 1)

        }

        output.innerHTML = message;
        message = '';
        
    })
}