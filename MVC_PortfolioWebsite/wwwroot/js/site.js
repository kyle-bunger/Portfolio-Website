// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const changeTheme = document.querySelector('#dark-mode-toggle');
changeTheme.addEventListener("click", function () {

    const everything = document.querySelectorAll('*');
    everything.forEach((item) => {
        item.classList.toggle('dark');
    });
});