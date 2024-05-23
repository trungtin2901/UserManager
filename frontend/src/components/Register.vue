<template>
  <div class="register-container">
    <div class="register-box">
      <div class="header">
        <img src="./icons/anhLan.jpg" alt="Cat Junior Shop" class="avatar">
        <h2>Cat Junior Shop</h2>
      </div>
      <h3>Register Account</h3>
      <form @submit.prevent="register">
        <div class="input-container">
          <label for="username">Username <span>*</span></label>
          <div class="input-with-error">
            <input type="text" id="username" v-model="username">
            <span v-if="!username && showErrors" class="error-message">Please enter your username</span>
          </div>
        </div>
        <div class="input-container">
          <label for="email">Email <span>*</span></label>
          <div class="input-with-error">
            <input id="email" v-model="email">
            <span v-if="!email && showErrors" class="error-message">Please enter your email</span>
            <span v-if="email && !isValidEmail(email) && showErrors" class="error-message">Please enter a valid email</span>
          </div>
        </div>
        <div class="input-container">
          <label for="password">Password <span>*</span></label>
          <div class="input-with-error">
            <div class="password-container">
              <input :type="showPassword ? 'text' : 'password'" id="password" v-model="password">
              <button type="button" @click="togglePassword('password')" class="toggle-password">
                <i :class="showPassword ? 'bi bi-eye-slash-fill' : 'bi bi-eye-fill'"></i>
              </button>
            </div>
            <span v-if="!password && showErrors" class="error-message">Please enter your password</span>
          </div>
        </div>
        <div class="input-container">
          <label for="retype-password">Retype Password <span>*</span></label>
          <div class="input-with-error">
            <div class="password-container">
              <input :type="showRetypePassword ? 'text' : 'password'" id="retype-password" v-model="retypePassword">
              <button type="button" @click="togglePassword('retypePassword')" class="toggle-password">
                <i :class="showRetypePassword ? 'bi bi-eye-slash-fill' : 'bi bi-eye-fill'"></i>
              </button>
            </div>
            <span v-if="!retypePassword && showErrors" class="error-message">Please enter your password</span>
            <span v-if="password && retypePassword && password !== retypePassword" class="error-message">Your password doesn't match, please try again</span>
          </div>
        </div>
        <button type="submit" class="register-button">Register</button>
      </form>
      <p>Already have an account? <a href="/login">Sign in</a></p>
    </div>
  </div>
</template>

<script>
import axios from 'axios';
import { useToast } from 'vue-toastification';
import 'bootstrap-icons/font/bootstrap-icons.css';

export default {
  data() {
    return {
      username: '',
      email: '',
      password: '',
      retypePassword: '',
      showPassword: false,
      showRetypePassword: false,
      showErrors: false,
    };
  },
  methods: {
    async register() {
      const toast = useToast();
      this.showErrors = true;
      if (!this.username || !this.email || !this.password || !this.retypePassword) {
        toast.error("Please fill in all required fields!");
        return;
      }
      if (!this.isValidEmail(this.email)) {
        toast.error("Please enter a valid email!");
        return;
      }
      if (this.password !== this.retypePassword) {
        toast.error("Passwords do not match!");
        return;
      }
      if (this.password.length < 6) {
        toast.error("Password must be at least 6 characters long!");
        return;
      }
      try {
        const response = await axios.post('/users/register', {
          username: this.username,
          email: this.email,
          password: this.password,
          confirmPassword: this.retypePassword, 
        });
        toast.success('Registration successful');
        // Handle successful registration (e.g., redirect to login page)
      } catch (error) {
        if (error.response && error.response.data) {
          toast.error(`Registration error: ${JSON.stringify(error.response.data)}`);
        } else {
          toast.error('Registration error');
        }
      }
    },
    isValidEmail(email) {
      const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
      return emailPattern.test(email);
    },
    togglePassword(input) {
      if (input === 'password') {
        this.showPassword = !this.showPassword;
      } else if (input === 'retypePassword') {
        this.showRetypePassword = !this.showRetypePassword;
      }
    },
  },
};
</script>

<style>
.register-container {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #b73939;
}

.register-box {
  width: 600px;
  padding: 20px;
  border: 1px solid #ddd;
  border-radius: 8px;
  background-color: #fff;
  text-align: center;
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
  margin-right: 15px;
}

h2 {
  margin: 10px 0;
  font-size: 24px;
  font-weight: normal;
}

h3 {
  margin: 20px 0;
  font-size: 40px;
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

.input-container label span {
  color: red;
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

.register-button {
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
.register-button:hover {
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
