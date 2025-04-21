// Admin Panel JS
document.addEventListener('DOMContentLoaded', function() {
    // Переключение между разделами
    const menuLinks = document.querySelectorAll('.menu li a');
    const contents = document.querySelectorAll('.content');
    
    menuLinks.forEach(link => {
      link.addEventListener('click', function(e) {
        e.preventDefault();
        
        // Удаляем active у всех ссылок
        menuLinks.forEach(item => {
          item.parentElement.classList.remove('active');
        });
        
        // Добавляем active к текущей ссылке
        this.parentElement.classList.add('active');
        
        // Скрываем все контенты
        contents.forEach(content => {
          content.classList.remove('active');
        });
        
        // Показываем нужный контент
        const target = this.getAttribute('href');
        document.querySelector(`${target}-content`).classList.add('active');
      });
    });
    
    // Модальное окно добавления товара
    const addProductBtn = document.querySelector('.add-product-btn');
    const addProductModal = document.getElementById('add-product-modal');
    const closeModalBtn = document.querySelector('.close-modal');
    const cancelBtn = document.querySelector('.cancel-btn');
    
    if (addProductBtn && addProductModal) {
      addProductBtn.addEventListener('click', () => {
        addProductModal.classList.add('active');
      });
      
      closeModalBtn.addEventListener('click', () => {
        addProductModal.classList.remove('active');
      });
      
      cancelBtn.addEventListener('click', () => {
        addProductModal.classList.remove('active');
      });
      
      // Закрытие модального окна при клике вне его
      addProductModal.addEventListener('click', (e) => {
        if (e.target === addProductModal) {
          addProductModal.classList.remove('active');
        }
      });
    }
    
    // Превью загружаемых изображений
    const productImagesInput = document.getElementById('product-images');
    const previewImagesContainer = document.querySelector('.preview-images');
    
    if (productImagesInput && previewImagesContainer) {
      productImagesInput.addEventListener('change', function() {
        previewImagesContainer.innerHTML = '';
        
        if (this.files) {
          Array.from(this.files).forEach(file => {
            const reader = new FileReader();
            
            reader.onload = function(e) {
              const img = document.createElement('img');
              img.src = e.target.result;
              previewImagesContainer.appendChild(img);
            }
            
            reader.readAsDataURL(file);
          });
        }
      });
    }
    
    // Изменение статуса заказа
    const statusSelects = document.querySelectorAll('.status-select');
    
    statusSelects.forEach(select => {
      select.addEventListener('change', function() {
        this.className = `status-select ${this.value}`;
        
        // Здесь можно добавить AJAX запрос для сохранения статуса
        console.log(`Статус изменен на: ${this.value}`);
      });
    });
    
    // Анимация карточек при загрузке
    const cards = document.querySelectorAll('.card');
    
    if (cards.length > 0) {
      cards.forEach((card, index) => {
        setTimeout(() => {
          card.style.opacity = '1';
          card.style.transform = 'translateY(0)';
        }, index * 100);
      });
    }
    

  });