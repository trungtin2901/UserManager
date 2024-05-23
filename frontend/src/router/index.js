import { createRouter, createWebHistory } from 'vue-router'
import Login from '@/components/Login.vue'
import Register from '@/components/Register.vue'
import UserManager from '@/components/UserManager.vue'

const routes = [
  { path: '/login', component: Login },
  { path: '/register', component: Register },
  { path: '/users', component: UserManager },
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router
