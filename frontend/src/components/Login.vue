<template>
  <div class="login-container">
    <div class="login-box">
      <div class="header">
        <img src="./icons/anhLan.jpg" alt="Cat Junior Shop" class="avatar">
        <h2>Cat Junior Shop</h2>
      </div>
      <h3>Login</h3>
      <form @submit.prevent="login">
        <div class="input-container">
          <label for="username">Username</label>
          <div class="input-with-error">
            <input type="text" id="username" v-model="username">
            <span v-if="error.username" class="error-message">Please enter your username</span>
          </div>
        </div>
        <div class="input-container">
          <label for="password">Password</label>
          <div class="input-with-error">
            <div class="password-container">
              <input :type="showPassword ? 'text' : 'password'" id="password" v-model="password">
              <button type="button" @click="togglePassword" class="toggle-password">
                <i :class="showPassword ? 'bi bi-eye-slash-fill' : 'bi bi-eye-fill'"></i>
              </button>
            </div>
            <span v-if="error.password" class="error-message">Please enter your password</span>
          </div>
        </div>
        <button type="submit" class="login-button" href="/user-manager">Login</button>
      </form>
      <p>Don't have an account yet? <a href="/register">Register here</a></p>
    </div>
  </div>
</template>


<script>
import axios from 'axios';
import { useToast } from 'vue-toastification';

export default {
  data() {
    return {
      username: '',
      password: '',
      error: {
        username: false,
        password: false,
      },
      showPassword: false,
    };
  },
  methods: {
    async login() {
      const toast = useToast();

      this.error.username = !this.username;
      this.error.password = !this.password;

      if (this.error.username || this.error.password) {
        toast.error('Please fill in all fields');
        return;
    }

      try {
        const response = await axios.post('/users/login', {
          username: this.username,
          password: this.password,
        });
        toast.success('Login successful');
        // Handle successful login (e.g., redirect to another page)
      } catch (error) {
        if (error.response) {
          if (error.response.status === 404) {
            toast.error('Username does not exist');
          } else if (error.response.status === 401) {
            toast.error('Wrong password');
          } else {
            toast.error('Login error');
          }
        } else {
          toast.error('Network error');
        }
      }
    },
    togglePassword() {
      this.showPassword = !this.showPassword;
    },
  },
};
</script>

<style>
.login-container {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #b73939;
}

.login-box {
  width: 600px;
  padding: 20px;
  border: 1px solid #ddd;
  border-radius: 8px;
  background-color: #fff;
  text-align: center;
}

.input-container {
  display: flex;
  align-items: flex-start;
  margin: 30px;
  text-align: left;
}

.input-container label {
  width: 200px;
  margin-right: 10px;
  font-weight: normal;
  display: flex;
  align-items: center;
}

.input-with-error {
  width: 100%;
  display: flex;
  flex-direction: column;
}

.input-with-error input {
  width: 400px; /* Chỉnh lại chiều rộng của ô input */
  padding: 8px;
  border: 1px solid #ddd;
  border-radius: 4px;
  position: relative;
}

.password-container {
  display: flex;
  align-items: center;
  position: relative;
  width: 100%;
}

.password-container input {
  width: 400px; /* Chỉnh lại chiều rộng của ô input */
  padding: 8px;
  border: 1px solid #ddd;
  border-radius: 4px;
  position: relative;
}

.toggle-password {
  background: none;
  border: none;
  cursor: pointer;
  position: absolute;
  right: 10px;
}

.error-message {
  color: red;
  font-size: 12px;
  margin-top: 5px;
}

.header {
  display: flex;
  align-items: center;
  justify-content: center;
  margin-bottom: 20px;
}

.avatar {
  width: 50px;
  height: 50px;
  border-radius: 50%;
  margin-right: 10px;
}

h2 {
  font-size: 24px;
  font-weight: normal;
  margin: 0;
}

h3 {
  margin: 20px 0;
  font-size: 32px;
  font-weight: normal;
}

.input-container {
  display: flex;
  align-items: center;
  margin: 30px;
  text-align: left;
}

.input-container label {
  width: 200px;
  margin-right: 10px;
  font-weight: normal;
  display: flex;
  align-items: center;
}

input {
  width: 100%;
  padding: 8px;
  border: 1px solid #ddd;
  border-radius: 4px;
  position: relative;
}

.password-container {
  display: flex;
  align-items: center;
  position: relative;
  width: 100%;
}

.password-container input {
  flex: 1;
}

.toggle-password {
  background: none;
  border: none;
  cursor: pointer;
  position: absolute;
  right: 10px;
}

.login-button {
  width: 100px;
  padding: 10px;
  background-color: #ff9800;
  border: none;
  border-radius: 4px;
  color: #fff;
  font-size: 16px;
  cursor: pointer;
  margin-bottom: 10px;
  transition: background-color 0.3s;
}
.login-button:hover {
  background-color: #e68900; /* Màu đậm hơn khi hover */
}

p {
  margin-top: 20px;
}

a {
  color: #007bff;
  text-decoration: none;
}
</style>