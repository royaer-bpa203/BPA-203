const app = document.getElementById("app");

// ---- CARD CONTAINER ----
const card = document.createElement("div");
card.style.width = "360px";
card.style.border = "1px solid #ddd";
card.style.borderRadius = "12px";
card.style.overflow = "hidden";
card.style.boxShadow = "0 3px 12px rgba(0,0,0,0.15)";
card.style.fontFamily = "Arial, sans-serif";
card.style.margin = "20px auto";
card.style.background = "#fff";

// ---- IMAGE SECTION ----
const imgContainer = document.createElement("div");
imgContainer.style.position = "relative";

const img = document.createElement("img");
img.src = "data:image/jpeg;base64,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";  // Burada öz şəkilinizi qoya bilərsiniz
img.style.width = "100%";
img.style.height = "220px";
img.style.objectFit = "cover";

// HEART ICON (interactive)
const heart = document.createElement("div");
heart.innerHTML = "♡";
heart.style.position = "absolute";
heart.style.top = "10px";
heart.style.right = "10px";
heart.style.fontSize = "28px";
heart.style.cursor = "pointer";
heart.style.color = "white";
heart.style.textShadow = "0 0 5px black";

// Heart click event
heart.addEventListener("click", () => {
    heart.innerHTML = heart.innerHTML === "♡" ? "♥" : "♡";
});

// Add image and heart to container
imgContainer.appendChild(img);
imgContainer.appendChild(heart);

// ---- DETAILS SECTION ----
const details = document.createElement("div");
details.style.padding = "16px";

const type = document.createElement("div");
type.innerText = "DETACHED HOUSE • 5Y OLD";
type.style.fontSize = "13px";
type.style.color = "#777";

const price = document.createElement("div");
price.innerText = "$750,000";
price.style.fontSize = "28px";
price.style.fontWeight = "bold";
price.style.margin = "8px 0";

const address = document.createElement("div");
address.innerText = "742 Evergreen Terrace";
address.style.color = "#555";
address.style.marginBottom = "20px";

// ---- BED/BATH INFO ----
const infoRow = document.createElement("div");
infoRow.style.display = "flex";
infoRow.style.justifyContent = "space-between";
infoRow.style.marginBottom = "20px";

function infoBlock(icon, label) {
    const div = document.createElement("div");
    div.style.display = "flex";
    div.style.alignItems = "center";
    div.style.gap = "6px";

    const i = document.createElement("span");
    i.innerHTML = icon;
    i.style.fontSize = "20px";

    const text = document.createElement("span");
    text.innerText = label;

    div.appendChild(i);
    div.appendChild(text);
    return div;
}

infoRow.appendChild(infoBlock("🛏️", "3 Bedrooms"));
infoRow.appendChild(infoBlock("🛁", "2 Bathrooms"));

// ---- REALTOR SECTION ----
const realtor = document.createElement("div");
realtor.style.borderTop = "1px solid #eee";
realtor.style.padding = "16px";

const rTitle = document.createElement("div");
rTitle.innerText = "REALTOR";
rTitle.style.color = "#777";
rTitle.style.fontSize = "13px";
rTitle.style.marginBottom = "10px";

const rRow = document.createElement("div");
rRow.style.display = "flex";
rRow.style.alignItems = "center";
rRow.style.gap = "12px";

const rImg = document.createElement("img");
rImg.src = "https://i0.wp.com/bey.az/wp-content/uploads/2021/09/d517948095831b241a414d053ee4c2e6.jpg?resize=736%2C920&ssl=1"; // Şəkil əlavə edin
rImg.style.width = "48px";
rImg.style.height = "48px";
rImg.style.borderRadius = "50%";
rImg.style.objectFit = "cover";

const rInfo = document.createElement("div");
const rName = document.createElement("div");
rName.innerText = "Tiffany Heffner";
rName.style.fontWeight = "600";

const rPhone = document.createElement("div");
rPhone.innerText = "(555) 555-4321";
rPhone.style.color = "#555";

rInfo.appendChild(rName);
rInfo.appendChild(rPhone);
rRow.appendChild(rImg);
rRow.appendChild(rInfo);

realtor.appendChild(rTitle);
realtor.appendChild(rRow);

// ---- APPEND EVERYTHING ----
details.appendChild(type);
details.appendChild(price);
details.appendChild(address);
details.appendChild(infoRow);

card.appendChild(imgContainer);
card.appendChild(details);
card.appendChild(realtor);

app.appendChild(card);
