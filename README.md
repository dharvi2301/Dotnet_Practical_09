# Output for the Test 1 and Test 3 are given below 
![image](https://github.com/user-attachments/assets/d429dda0-9585-4e4d-abf0-795d76a2a929)

# Test case output
![image](https://github.com/user-attachments/assets/7ba8d326-5ac0-444b-a4df-002a1c7f0639)

# Test 2
# ASP.NET MVC - JavaScript Text Styling Demo

## 📋 Objective

Create a web page in an ASP.NET MVC project that demonstrates basic JavaScript-based styling features through user interaction.

---

## 🧩 Features Implemented

- **PRINT TEXT**: Displays "Hello World" in a label.
- **BOLD**: Applies bold style to the displayed text.
- **ITALIC**: Applies italic style to the displayed text.
- **UNDERLINE**: Applies underline to the displayed text.
- **RESET**: Resets the text style to normal/default.

---

## 🏗️ Implementation Details

### 1. View (`StyleDemo.cshtml`)

```html
@{
    ViewBag.Title = "Style Demo";
}

<h2>Text Styling with JavaScript</h2>

<!-- Label -->
<p id="textLabel" style="font-size: 20px;">&nbsp;</p>

<!-- Buttons -->
<button onclick="printText()">PRINT TEXT</button>
<button onclick="makeBold()">BOLD</button>
<button onclick="makeItalic()">ITALIC</button>
<button onclick="makeUnderline()">UNDERLINE</button>
<button onclick="resetStyle()">RESET</button>

<!-- JavaScript Functions -->
<script>
    function printText() {
        document.getElementById("textLabel").innerText = "Hello World";
    }

    function makeBold() {
        document.getElementById("textLabel").style.fontWeight = "bold";
    }

    function makeItalic() {
        document.getElementById("textLabel").style.fontStyle = "italic";
    }

    function makeUnderline() {
        document.getElementById("textLabel").style.textDecoration = "underline";
    }

    function resetStyle() {
        const label = document.getElementById("textLabel");
        label.style.fontWeight = "normal";
        label.style.fontStyle = "normal";
        label.style.textDecoration = "none";
    }
</script>

```
# Final Output
## Print Text
![image](https://github.com/user-attachments/assets/dad2e19e-1c9b-4c97-861c-506b9e794623)

## Bold
![image](https://github.com/user-attachments/assets/a7b28f3e-37ca-4090-86f7-cb040a8d83d6)

## Italics
![image](https://github.com/user-attachments/assets/5b8ffd72-f5ec-40a7-9d19-31a0f0d3cdfd)

## Underline
![image](https://github.com/user-attachments/assets/c2e62e98-e84d-44ca-a18f-00584d03a02b)

## Reset
![image](https://github.com/user-attachments/assets/9b51a089-f6dc-44d4-866a-be6219e2bb17)






