function getArticleGenerator(articles) {
    const content = document.getElementById("content");

    index = 0;

    return () => {
        if (index < articles.length) {

            let article = document.createElement('article')
            article.innerHTML = articles[index];
            content.appendChild(article)
            index++;
        }
    }
}