window.addEventListener('scroll', function () {
    var header = document.getElementById('main-header');
    var logo = document.getElementById('logo');
    var scrollTop = window.pageYOffset || document.documentElement.scrollTop;

    if (scrollTop > 0) {
        header.style.height = '60px'; // Змінюємо висоту хедеру при прокручуванні
        logo.style.transform = 'scale(0.7)'; // Змінюємо розмір логотипу
    } else {
        header.style.height = '90px'; // Повертаємо висоту хедеру до початкового значення
        logo.style.transform = 'scale(1)'; // Повертаємо розмір логотипу до початкового значення
    }
});