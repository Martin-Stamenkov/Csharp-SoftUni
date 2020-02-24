function solve() {

  let buttons = document.getElementsByTagName('button');
  let generate = buttons[0];
  let buy = buttons[1];

  let data = document.querySelector("#exercise > div > div > div > div > table > tbody")

  generate.addEventListener('click', () => {
    let inputJson = document.querySelector("#exercise > textarea").value;
    let parsedInput = JSON.parse(inputJson);

    for (const obj of parsedInput) {

      let tr = document.createElement('tr');
      let tdImg = document.createElement('td');
      let img = document.createElement('img');
      img.src = obj.img;
      tdImg.appendChild(img);

      let tdName = document.createElement('td');
      tdName.innerHTML = obj.name;

      let tdPrice = document.createElement('td');
      tdPrice.innerHTML = obj.price

      let tdDecFactor = document.createElement('td')
      tdDecFactor.innerHTML = obj.decFactor;

      let tdCheckBox = document.createElement('td');
      let input = document.createElement('input');
      input.type = 'checkbox'
      tdCheckBox.appendChild(input);

      tr.appendChild(tdImg);
      tr.appendChild(tdName);
      tr.appendChild(tdPrice);
      tr.appendChild(tdDecFactor);
      tr.appendChild(tdCheckBox);

      data.appendChild(tr);
    }

  })

  buy.addEventListener('click', () => {

    let inputs = document.getElementsByTagName("input");
    let output = document.querySelector("#exercise > textarea:nth-child(5)")
    const bought = [];
    for (i = 0; i < inputs.length; i++) {
      if (inputs[i].checked === true) {
        bought.push(data.children[i]);

      }
    }
    const names = [];
    let totalPrice = 0;
    let average = 0;

    for (const item of bought) {
      names.push(item.children[1].innerHTML);
      totalPrice += Number(item.children[2].innerHTML);
      average+=Number(item.children[3].innerHTML);
    }

    output.value += `Bought furniture: ${names.join(', ')}`
    output.value += `\nTotal price: ${totalPrice.toFixed(2)}`
    output.value += `\nAverage decoration factor: ${average/bought.length}`
  })
}
