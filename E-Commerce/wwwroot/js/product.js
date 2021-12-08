function Toogle() {
    if (document.activeElement.className == 'dd') {
        var i = document.getElementById('icon');
        i.className = 'fas fa-angle-up';
    }

    if (document.activeElement.onclick) {
        document.activeElement.onclick = function () {
            var i = document.getElementById('icon');
            i.className = 'fas fa-angle-down';
            document.activeElement.blur();
        }
    }

    Toogle();
};