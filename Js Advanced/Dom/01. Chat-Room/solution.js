function solve() {

   let chatInput = document.getElementById("chat_input")
   let send = document.getElementById("send");
   let message = document.getElementById("chat_messages");

   send.addEventListener('click', () => {
      let div = document.createElement("div")
      div.className = "message my-message";
      div.innerHTML = chatInput.value;
      message.appendChild(div)
      chatInput.value = '';
   })
}


