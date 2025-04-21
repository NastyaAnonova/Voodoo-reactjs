function saveCartToLocalStorage(cart) {
  localStorage.setItem("cart", JSON.stringify(cart));
}

function loadCartFromLocalStorage() {
  const cart = localStorage.getItem("cart");
  return cart ? JSON.parse(cart) : [];
}

function updateCartCount() {
  const cart = loadCartFromLocalStorage();
  const totalItems = cart.reduce((sum, item) => sum + item.quantity, 0);

  document.querySelectorAll(".cart-count").forEach((el) => {
    el.textContent = totalItems;
    el.classList.add("animate");
    setTimeout(() => el.classList.remove("animate"), 300);
  });

  document.querySelectorAll(".bx-cart + span").forEach((span) => {
    span.textContent = totalItems;
    span.classList.add("animate");
    setTimeout(() => span.classList.remove("animate"), 300);
  });
}

function addToCart(product) {
  const cart = loadCartFromLocalStorage();
  const existingItem = cart.find((item) => item.id === product.id);

  if (existingItem) {
    existingItem.quantity += 1;
  } else {
    cart.push({
      ...product,
      quantity: 1,
    });
  }

  saveCartToLocalStorage(cart);
  updateCartCount();
  showAddedToCartMessage(product.title);
}

function showAddedToCartMessage(productName) {
  const message = document.createElement("div");
  message.className = "cart-message";
  message.innerHTML = `
      <span>${productName} добавлен в корзину!</span>
      <a href="cart.html">Перейти в корзину</a>
    `;
  document.body.appendChild(message);

  setTimeout(() => {
    message.classList.add("show");
  }, 100);

  setTimeout(() => {
    message.classList.remove("show");
    setTimeout(() => message.remove(), 500);
  }, 3000);
}

function renderCartItems() {
  const cart = loadCartFromLocalStorage();
  const cartTable = document.querySelector(".cart table");

  if (!cartTable) return;

  while (cartTable.rows.length > 1) {
    cartTable.deleteRow(1);
  }

  let subtotal = 0;

  cart.forEach((item) => {
    const row = cartTable.insertRow();

    const cell1 = row.insertCell(0);
    cell1.innerHTML = `
        <div class="cart-info">
          <img src="${item.image}" alt="${item.title}" />
          <div>
            <p>${item.title}</p>
            <span>$${item.price.toFixed(2)}</span> <br />
            <a href="#" class="remove-item" data-id="${item.id}">Удалить</a>
          </div>
        </div>
      `;

    const cell2 = row.insertCell(1);
    cell2.innerHTML = `<input type="number" value="${item.quantity}" min="1" data-id="${item.id}" class="quantity-input" />`;

    const totalPrice = item.price * item.quantity;
    subtotal += totalPrice;
    const cell3 = row.insertCell(2);
    cell3.textContent = `$${totalPrice.toFixed(2)}`;
  });

  const shipping = 50;
  const total = subtotal + shipping;

  document.querySelector(
    ".total-price td:nth-child(2)"
  ).textContent = `$${subtotal.toFixed(2)}`;
  document.querySelector(
    ".total-price tr:nth-child(2) td:nth-child(2)"
  ).textContent = `$${shipping.toFixed(2)}`;
  document.querySelector(
    ".total-price tr:nth-child(3) td:nth-child(2)"
  ).textContent = `$${total.toFixed(2)}`;

  addCartEventListeners();
}

function addCartEventListeners() {
  document.querySelectorAll(".remove-item").forEach((button) => {
    button.addEventListener("click", (e) => {
      e.preventDefault();
      const productId = button.dataset.id;
      removeFromCart(productId);
    });
  });

  document.querySelectorAll(".quantity-input").forEach((input) => {
    input.addEventListener("change", (e) => {
      const productId = e.target.dataset.id;
      const newQuantity = parseInt(e.target.value);
      updateCartItemQuantity(productId, newQuantity);
    });
  });
}

function removeFromCart(productId) {
  let cart = loadCartFromLocalStorage();
  cart = cart.filter((item) => item.id !== productId);
  saveCartToLocalStorage(cart);
  renderCartItems();
  updateCartCount();
}

function updateCartItemQuantity(productId, newQuantity) {
  let cart = loadCartFromLocalStorage();
  const item = cart.find((item) => item.id === productId);

  if (item) {
    item.quantity = newQuantity;
    saveCartToLocalStorage(cart);
    renderCartItems();
    updateCartCount();
  }
}

function checkout() {
  const cart = loadCartFromLocalStorage();
  if (cart.length === 0) {
    alert("Корзина пуста!");
    return;
  }

  const checkoutWidget = new window.YooMoneyCheckoutWidget({
    confirmation_token: "ВАШ_ТОКЕН",
    return_url: window.location.href,
    error_callback: (error) => {
      console.error("Ошибка оплаты:", error);
    },
  });

  checkoutWidget.open();
}


document.addEventListener("DOMContentLoaded", () => {
  updateCartCount();

  document.querySelectorAll(".product-item .bx-cart").forEach((button) => {
    button.addEventListener("click", (e) => {
      e.preventDefault();
      const productItem = button.closest(".product-item");
      const product = {
        id: productItem.dataset.id || Date.now().toString(),
        title: productItem.querySelector(".card__title").textContent,
        price: parseFloat(
          productItem.querySelector(".card__price").textContent.replace("$", "")
        ),
        image: productItem.querySelector(".card__image").src,
        discount:
          parseInt(
            productItem
              .querySelector(".card__discount")
              ?.textContent.replace("%", "")
          ) || 0,
      };
      addToCart(product);
    });
  });

  if (document.querySelector(".cart")) {
    renderCartItems();

    document.querySelector(".checkout.btn")?.addEventListener("click", (e) => {
      e.preventDefault();
      checkout();
    });
  }

  window.addEventListener("storage", (e) => {
    if (e.key === "cart") {
      updateCartCount();
      if (document.querySelector(".cart")) {
        renderCartItems();
      }
    }
  });
});
