function solve() {
   let courses = document.getElementsByTagName('input')

   let signButton = document.getElementsByTagName('button')[0];

   let myCoursesTextarea = document.querySelector("#myCourses > div.courseBody").childNodes[1];
   let Cost = document.querySelector("#myCourses > div.courseFoot");

   console.log(myCoursesTextarea)

   signButton.addEventListener('click', () => {

      let selectCourses = {};
      Array.from(courses).forEach(course => {

         if (course.checked) {

            let currentCourse = course.value;

            if (currentCourse === 'js-fundamentals') {

               selectCourses['JS-Fundamentals'] = 170;

            } else if (currentCourse === 'js-advanced') {

               selectCourses['JS-Advanced'] = 180;

            } else if (currentCourse === 'js-applications') {

               selectCourses['JS-Applications'] = 190;

            } else if (currentCourse === 'js-web') {

               selectCourses['JS-Web'] = 490;

            }
         }

      })
      let coursesName = Object.keys(selectCourses);

      if (coursesName.includes('JS-Fundamentals') && coursesName.includes('JS-Advanced')) {
         selectCourses['JS-Advanced'] = selectCourses['JS-Advanced'] * 0.09;

      }
      if (coursesName.includes('JS-Fundamentals') && coursesName.includes('JS-Advanced') && coursesName.includes('JS-Applications')) {
         selectCourses = selectCourses['JS-Advanced'] * 0.94;
         selectCourses = selectCourses['JS-Applications'] * 0.94;
         selectCourses = selectCourses['JS-Fundamentals'] * 0.94;
      }
      if (coursesName.length === 4) {
         coursesName.push('HTML and CSS');
      }

      let online = courses[5]

      let totalCost = 0;

      for (const price in selectCourses) {
         totalCost += selectCourses[price]
      }

      if (online.checked) {
         totalCost *= 0.94;
      }
      totalCost -= totalDiscount
      for (const course of coursesName) {

         let li = document.createElement('li');
         li.innerHTML = course;
         myCoursesTextarea.appendChild(li);
      }
      Cost.firstElementChild.innerHTML = `Cost: ${(Math.floor(totalCost).toFixed(2))} BGN`

   })
}

solve();