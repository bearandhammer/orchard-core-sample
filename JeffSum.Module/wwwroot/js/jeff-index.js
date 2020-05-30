// Function that performs a physical copy of content (from the designated text area) to the clipboard
function performCopy() {
    document.querySelector('#JeffIpsumContentTextArea').select();
    document.execCommand('Copy');
}

// Function that handles UI alterations to the 'Copy to Clipboard' button, along with the actual copy!
function copyToClipboard(buttonElement) {
    if (buttonElement) {
        buttonElement.innerText = "Copied!";

        performCopy();

        setTimeout(() => buttonElement.innerText = "Copy to Clipboard", 2000);
    }
} 

// 'Copy to Clipboard' button click handler
document.querySelector('#CopyToClipboardButton').addEventListener('click', el => copyToClipboard(el.target));
