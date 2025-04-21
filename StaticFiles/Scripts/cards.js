const products = [
    {
        id: 1,
        title: "ФУТБОЛКА РОЗОВАЯ КАВАЙИ. ОДЕЖДА",
        price: 100,
        image: "/StaticFiles/Images/product-2.jpg",
        discount: 50,
    },
    {
        id: 2,
        title: "ФИОЛЕТОВАЯ КОФТА. ОДЕЖДА",
        price: 40,
        image: "https://avatars.mds.yandex.net/i?id=1590fad1595c858560878aaf802da0ed_l-11008180-images-thumbs&n=13",
        discount: 20,
    },
    {
        id: 3,
        title: "РУБАШКА С ГАЛСТУКОМ КОТА. ОДЕЖДА",
        price: 30,
        image: "/StaticFiles/Images/product-3.jpg",
        discount: 0,
    },
    {
        id: 4,
        title: "БЕЛО-РОЗОВАЯ ФУТБОЛКА С АНИМЕ ПРИНТОМ. ОДЕЖДА",
        price: 80,
        image: "/StaticFiles/Images/product-1.jpg",
        discount: 40,
    },
    {
        id: 5,
        title: "НАБОР ЗНАЧКОВ РАДУЖНЫЙ. АКСЕССУАРЫ",
        price: 12,
        image: "https://i.pinimg.com/474x/09/71/43/09714311ed9dcfcace32242748ac0044--kawaii-jewelry-kawaii-accessories.jpg",
        discount: 20,
    },
    {
        id: 6,
        title: "НАБОР ЗНАЧКОВ ИЗ МУЛЬТФИЛЬМА HELLO KITTY. АКСЕССУАРЫ",
        price: 3,
        image: "https://ceram-pro.ru/300628/images_content-1/10-шт-кавайные-аксессуары-сделай.jpeg",
        discount: 50,
    },
    {
        id: 7,
        title: "XУДИ РОЗОВОЕ КЛУБНИЧНОЕ.ОДЕЖДА",
        price: 40,
        image: "https://i.pinimg.com/736x/3f/56/2d/3f562d0a79cc1d6c3229314be704c9be--sweet-fashion-punk-fashion.jpg",
        discount: 0,
    },
    {
        id: 8,
        title: "СЕРЁЖКИ МОРОЖЕНОЕ. УКРАШЕНИЯ",
        price: 5,
        image: "https://i.pinimg.com/736x/da/15/15/da1515026cc08f25d430f49607d084a0--fimo-kawaii-kawaii-crafts.jpg",
        discount: 20,
    },
    {
        id: 9,
        title: "СУМКА МИШКА. АКСЕССУАРЫ",
        price: 32,
        image: "https://gd4.alicdn.com/imgextra/i1/0/TB1KBVnGXXXXXc3aXXXXXXXXXXX_!!0-item_pic.jpg",
        discount: 0,
    },
    {
        id: 10,
        title: "СВИТЕР ЗВЕЗДЫ. ОДЕЖДА",
        price: 24,
        image: "https://i.pinimg.com/474x/6b/ad/81/6bad812f9bf182d6d4196ad242e75452--star-print-color-blue.jpg",
        discount: 25,
    },
    {
        id: 11,
        title: "ПЛАТЬЕ С ЗАЙЦЕМ.ОДЕЖДА",
        price: 82,
        image: "https://avatars.mds.yandex.net/get-mpic/1912105/2a0000019166c5254ffb7941dc5128e21b39/orig",
        discount: 30,
    },
    {
        id: 12,
        title: "МОРСКОЕ ПЛАТЬЕ. ОДЕЖДА",
        price: 110,
        image: "https://www-s.mlo.me/upen/v/2021/202110/20211015/202110151452396535516.jpg",
        discount: 0,
    },
    {
        id: 13,
        title: "РОЗОВАЯ СУМКА. АКСЕССУАРЫ",
        price: 23,
        image: "https://i.pinimg.com/736x/fe/4c/6f/fe4c6f85513d0ef3d5ab9dd00d2844ec--kawaii-bags-kawaii-cute.jpg",
        discount: 70,
    },
    {
        id: 14,
        title: "HELLO KITTY ЗАКОЛКА. УКРАШЕНИЯ",
        price: 7,
        image: "https://avatars.mds.yandex.net/i?id=73d5b24f433ba029faddb5bd5860a1c9_sr-12325301-images-thumbs&n=13",
        discount: 70,
    },
    {
        id: 15,
        title: "ШАПКА-КОТИК. ОДЕЖДА",
        price: 10,
        image: "https://avatars.mds.yandex.net/i?id=3a180c267f2d98e6dda3c20a7cde17f7_l-4571642-images-thumbs&n=13",
        discount: 0,
    },
    {
        id: 16,
        title: "ФУТБОЛКА РОЗОВАЯ ДЕВОЧКА. ОДЕЖДА",
        price: 10,
        image: "https://i.pinimg.com/736x/c2/ec/08/c2ec08b6d46e53212dcb22ad7ea0d8a7.jpg",
        discount: 40,
    },
    {
        id: 17,
        title: "ЧЕРНОЕ XУДИ. ОДЕЖДА",
        price: 25,
        image: "https://avatars.mds.yandex.net/i?id=9e12fc064377f0093e0655f51be64888_l-5286004-images-thumbs&n=13",
        discount: 70,
    },
    {
        id: 18,
        title: "XУДИ КОРГИ. ОДЕЖДА",
        price: 30,
        image: "https://avatars.mds.yandex.net/i?id=a1aad7a5a185bf08764af2c091291d12_l-10243565-images-thumbs&n=13",
        discount: 0,
    },
    {
        id: 19,
        title: "КРАБИК ДЛЯ ВОЛОС. АКСЕССУАРЫ",
        price: 10,
        image: "https://i.pinimg.com/736x/cd/9e/e0/cd9ee0a4d2df0c79f06ea8b416a4658f.jpg",
        discount: 40,
    },
    {
        id: 20,
        title: "СЕРЁЖКИ HELLO KITTY. УКРАШЕНИЯ",
        price: 8,
        image: "https://i.pinimg.com/originals/f5/39/97/f53997b5e8d243fc9f3f583a662d9b1f.jpg",
        discount: 20,
    },
    {
        id: 21,
        title: "ДЖИНСОВАЯ ЮБКА. ОДЕЖДА",
        price: 20,
        image: "https://avatars.mds.yandex.net/i?id=8c74555c7c13a7aea4d627e33706b6f4_sr-12491641-images-thumbs&n=13",
        discount: 60,
    },
    {
        id: 22,
        title: "ЧЕРНАЯ ЮБКА-СЕРДЦЕ. ОДЕЖДА",
        price: 18,
        image: "https://avatars.mds.yandex.net/i?id=4cd2ea38ba3cb1ec131a884dd9add91c_l-4387671-images-thumbs&n=13",
        discount: 40,
    },
    {
        id: 23,
        title: "ЧОКЕР КЛУБНИКА. УКРАШЕНИЯ",
        price: 5,
        image: "https://i.pinimg.com/736x/39/80/51/39805163e5badaf473c8de2e2a12c4f7.jpg",
        discount: 0,
    },
    {
        id: 24,
        title: "СУМКА СОБАКА. АКСЕССУАРЫ",
        price: 13,
        image: "https://avatars.mds.yandex.net/i?id=63958f816e5e328d2dfe48db1d5f50eb_sr-11395047-images-thumbs&n=13",
        discount: 0,
    },
    {
        id: 25,
        title: "КОМИНЕЗОН МИШКА. ОДЕЖДА",
        price: 36,
        image: "https://i.pinimg.com/736x/be/b9/ce/beb9ceab7a9ab966cf0ef9a66f50538b.jpg",
        discount: 40,
    },
    {
        id: 26,
        title: "РУБАШКА ЗАЙЧИК. ОДЕЖДА",
        price: 20,
        image: "https://avatars.mds.yandex.net/i?id=4817fc1238bd015f670aed0127e9f2076495da4e-10641465-images-thumbs&n=13",
        discount: 50,
    },
    {
        id: 27,
        title: "РУБАШКА HELLO KITTY. ОДЕЖДА",
        price: 32,
        image: "https://avatars.mds.yandex.net/i?id=c59264ed6306cf7d270b3c797b70769c_sr-5209934-images-thumbs&n=13",
        discount: 0,
    },
    {
        id: 28,
        title: "РУБАШКА КОТИК. ОДЕЖДА",
        price: 20,
        image: "https://avatars.mds.yandex.net/i?id=c2ed013623341cf1af885e829088f476_l-5234951-images-thumbs&n=13",
        discount: 55,
    },
    {
        id: 29,
        title: "ФУТБОЛКА РЫЖИЙ КОТ. ОДЕЖДА",
        price: 28,
        image: "https://imgaz3.staticbg.com/thumb/large/oaupload/banggood/images/1B/4A/03bdfad4-020b-44e9-a005-ab9db30fd383.jpg",
        discount: 20,
    },
    {
        id: 30,
        title: "ВИНТАЖНАЯ РУБАШКА. ОДЕЖДА",
        price: 320,
        image: "https://avatars.mds.yandex.net/i?id=7f1c67f5bfef367778b9b16010dcd135_sr-12140636-images-thumbs&n=13",
        discount: 0,
    },
    {
        id: 31,
        title: "ЗАКОЛКА ЗАЙЧИК. УКРАШЕНИЯ",
        price: 10,
        image: "https://i.pinimg.com/originals/c3/68/d9/c368d98dcad85378d170d1ab3b5e93e5.jpg",
        discount: 80,
    },
    {
        id: 32,
        title: "МУРСКАЯ РУБАШКА. ОДЕЖДА",
        price: 35,
        image: "https://avatars.mds.yandex.net/i?id=a6adca12440e5444754de0680a8b2ee2f9bb05b3-5284012-images-thumbs&n=13",
        discount: 20,
    },
    {
        id: 33,
        title: "XУДИ XОШИНО АЙ. ОДЕЖДА",
        price: 300,
        image: "https://avatars.mds.yandex.net/i?id=56a6ce77e6633cc57e9b9339d1b846ca_sr-12684404-images-thumbs&n=13",
        discount: 0,
    },
    {
        id: 34,
        title: "ЗНАЧКИ КАВАЙИ. АКСЕССУАРЫ",
        price: 3,
        image: "https://i.pinimg.com/474x/9d/68/47/9d6847a66920a78716b785d3ac08cd24.jpg",
        discount: 40,
    },
    {
        id: 35,
        title: "ФУТБОЛКА ГОЛУБАЯ ДЕВОЧКА. ОДЕЖДА",
        price: 23,
        image: "https://i.pinimg.com/736x/5e/7b/5b/5e7b5bda53da7e11537c79eac7464d9f.jpg",
        discount: 20,
    },
    {
        id: 36,
        title: "ЛАПКИ КОШАЧЬИ. АКСЕССУАРЫ",
        price: 13,
        image: "https://avatars.mds.yandex.net/i?id=a4dc902a1445d82f20d9da2cc039c70b_l-8456725-images-thumbs&ref=rim&n=13&w=800&h=800",
        discount: 0,
    },
];

const productCenter = document.querySelector('.product-center');
const itemsPerPage = 6;
const select = document.querySelector('select');
const paginationContainer = document.querySelector(".pagination")


function createProductCard(product) {
    return `
    <div class="product-item">
      <div class="overlay">
        <a href="#">
          <img src="${product.image}" alt="${product.title}" class="card__image">
        </a>
        ${product.discount > 0 ? `<span class="card__discount">${product.discount}%</span>` : ''}
      </div>
      <div class="product-info">
        <span class="card__title">${product.title}</span>
        <h4 class="card__price">$${product.price}</h4>
      </div>
      <ul class="icons">
        <li><i class="bx bx-heart"></i></li>
        <li><i class="bx bx-search"></i></li>
        <li><i class="bx bx-cart"></i></li>
      </ul>
    </div>
  `;
}

function displayProducts(productsToDisplay) {
    productCenter.innerHTML = productsToDisplay.map(createProductCard).join('');
}


function updatePagination(totalPages, sortedProducts) {
    paginationContainer.innerHTML = ''; // Очищаем существующую пагинацию
    for (let i = 1; i <= totalPages; i++) {
        const pageLink = document.createElement('a');
        pageLink.href = '#';
        pageLink.textContent = i;
        pageLink.classList.add('card_nav');
        pageLink.addEventListener('click', () => {
            displayProducts(sortedProducts.slice((i - 1) * itemsPerPage, i * itemsPerPage));
        });
        paginationContainer.appendChild(pageLink);
    }
}

select.addEventListener('change', () => {
    let sortedProducts = [...products];
    switch (select.value) {
        case '1':
            break;
        case '3':
            sortedProducts.sort((a, b) => b.price - a.price);
            break;
        case '4':
            sortedProducts.sort((a, b) => a.price - b.price);
            break;
        case '5':
            sortedProducts.sort((a, b) => b.discount - a.discount);
            break;
    }

    const totalPages = Math.ceil(sortedProducts.length / itemsPerPage);
    updatePagination(totalPages, sortedProducts);
    displayProducts(sortedProducts.slice(0, itemsPerPage));
});


const initialSortedProducts = [...products];
const totalPages = Math.ceil(initialSortedProducts.length / itemsPerPage);
updatePagination(totalPages, initialSortedProducts);
displayProducts(initialSortedProducts.slice(0, itemsPerPage));