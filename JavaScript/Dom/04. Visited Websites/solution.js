function solve() {

  let websites = document.getElementsByTagName("a");
  let visitors = document.getElementsByTagName("p");

  for (let i = 0; i < websites.length; i++) {
    websites[i].addEventListener('click', () => {

      let visit = Number(visitors[i].innerHTML.split(' ')[1])
      visitors[i].innerHTML = `visited ${visit+1} times`
    
    })
  }

}