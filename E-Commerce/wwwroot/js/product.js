function Toogle() {
    document.activeElement.focus();
    var i = document.getElementById('icon');
    i.className = 'fas fa-angle-up';
    
};

function Dropdown() {
    Toogle();

    if (document.activeElement.onclick) {
        document.activeElement.onclick = function () {
            var i = document.getElementById('icon');
            i.className = 'fas fa-angle-down';
            document.activeElement.blur();
            document.activeElement === null;
        }
    }
}

function SetSize(val) {
    result = document.getElementById('size');
    result.value = result.value ? parseInt(val) : parseInt(val);
}
