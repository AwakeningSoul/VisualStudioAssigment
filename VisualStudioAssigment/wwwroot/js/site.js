// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//music notes
document.addEventListener('DOMContentLoaded', function () {
    var musicNote = document.getElementById('music-note');
    var position = -50;
    var animationInterval = setInterval(function () {
        position += 1; // Adjust the speed by changing this value
        musicNote.style.left = position + 'px';
        if (position >= window.innerWidth) {
            position = -50;
        }
    }, 50); // Adjust the interval for smoother or faster animation
});