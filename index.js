const scripts = [
    {
        "name": "Enable",
        "description": "Enables a GameObject when you touch it.\nRequires a collider with Is Trigger enabled."
    },
    {
        "name": "Disable",
        "description": "Disables a GameObject when you touch it.\nRequires a collider with Is Trigger enabled."
    },
    {
        "name": "Hitsound",
        "description": "Plays a hit sound whenever you touch it.\nRequires a collider with Is Trigger disabled."
    },
];

const scriptsdiv = document.getElementById("scripts");
scripts.forEach(script => {
    createScript(script);
});

function createScript(script) {
    const element = document.createElement("div");
    element.classList = "script-button";
    
    const img = document.createElement("img");
    img.src = "img/script.png";
    element.appendChild(img);

    element.appendChild(document.createElement("br"));

    const name = document.createElement("p");
    name.style = "text-align: center";
    name.innerText = script.name;

    const description = document.createElement("p");
    description.style = "text-align: center";
    description.innerText = script.description;

    const download = document.createElement("a");
    const url = "scripts/" + script.name.replaceAll(" ", "") + ".cs";
    download.href = url;
    download.download = url.split('/').pop()

    element.appendChild(name);
    element.appendChild(description);
    element.appendChild(download);

    element.onclick = function() {
        download.click();
    }

    scriptsdiv.appendChild(element);
}