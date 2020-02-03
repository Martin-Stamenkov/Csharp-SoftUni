function solve() {

  let question = document.getElementById('quizzie');

  let sections = document.getElementsByTagName('section');

  let result  = document.querySelector("#results > li > h1")

  let totalCorrectAnswers = 0;
  let currentQuestion = 0;

  let correctAnswers = ['onclick', 'JSON.stringify()', 'A programming API for HTML and XML documents']

  question.addEventListener('click', (e) => {

    if (e.target.className === 'answer-text') {
      
      sections[currentQuestion].style.display = 'none'
      currentQuestion++;
      if (correctAnswers.includes(e.target.innerHTML)) {

        totalCorrectAnswers++;
      }

    }
    if (currentQuestion < 3) {
      sections[currentQuestion].style.display = 'block'
    } else {
      
      document.querySelector("#results").style.display = 'block'
      if (totalCorrectAnswers < 3) {
        result.innerHTML = `You have ${totalCorrectAnswers} right answers`;
      } else {
        result.innerHTML = 'You are recognized as top JavaScript fan!';
      }
      
    }



  })

}
