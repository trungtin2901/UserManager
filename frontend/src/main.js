import './assets/style.css';
import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import Toast from "vue-toastification";
import "vue-toastification/dist/index.css";
import axios from 'axios';

axios.defaults.baseURL = 'http://localhost:5294/api/';
//Toast
const toAst = {
    position: "top-right",
    timeout: 5000,
    closeOnClick: true,
    pauseOnFocusLoss: true,
    pauseOnHover: true,
    draggable: true,
    draggablePercent: 0.6,
    showCloseButtonOnHover: false,
    hideProgressBar: true,
    closeButton: "button",
    icon: true,
    rtl: false
}
const app = createApp(App);

app.use(router);
app.use(Toast, toAst)
app.config.globalProperties.$axios = axios;
app.mount('#app');

// Thêm CSS để đổi nền thành gradient
const style = document.createElement('style');
style.textContent = `
  body {
    background: linear-gradient(to bottom, #0081A7, #00AFB9);
  }
`;
document.head.appendChild(style);
