
    function printText() {
        const label = document.getElementById("textLabel");
    label.innerText = "Hello World";
    }

    function makeBold() {
        const label = document.getElementById("textLabel");
    label.style.fontWeight = "bold";
    }

    function makeItalic() {
        const label = document.getElementById("textLabel");
    label.style.fontStyle = "italic";
    }

    function makeUnderline() {
        const label = document.getElementById("textLabel");
    label.style.textDecoration = "underline";
    }

    function resetStyle() {
        const label = document.getElementById("textLabel");
    label.style.fontWeight = "normal";
    label.style.fontStyle = "normal";
    label.style.textDecoration = "none";
    }
