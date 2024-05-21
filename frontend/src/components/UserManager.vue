<template>
  <div class="user-manager">
    <header>
      <div class="logo-container">
        <img src="./icons/anhLan.jpg" alt="Cat Junior Shop Logo" class="logo">
        <span>Cat Junior Shop</span>
      </div>
      <div class="search-container">
        <input type="text" placeholder="Search" v-model="searchQuery" class="search-input">
        <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 512 512" class="search-icon">
          <path d="M416 208c0 45.9-14.9 88.3-40 122.7L502.6 457.4c12.5 12.5 12.5 32.8 0 45.3s-32.8 12.5-45.3 0L330.7 376c-34.4 25.2-76.8 40-122.7 40C93.1 416 0 322.9 0 208S93.1 0 208 0S416 93.1 416 208zM208 352a144 144 0 1 0 0-288 144 144 0 1 0 0 288z"/>
        </svg>
      </div>
    </header>
    <div class="content">
      <aside>
        <ul>
          <li class="active">User</li>
        </ul>
      </aside>
      <main>
        <h2>User manager</h2>
        <div class="actions">
          <button @click="deleteUsers" class="delete-button">Delete</button>
          <button @click="createUser" class="create-button">Create</button>
        </div>
        <table>
          <thead>
            <tr>
              <th>
                <input type="checkbox" v-model="selectAll" @change="toggleSelectAll">
              </th>
              <th @click="sortUsers('id')">USER ID</th>
              <th>NAME</th>
              <th>PHONE</th>
              <th>EMAIL</th>
              <th>ADDRESS</th>
              <th>ACTIONS</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="user in paginatedUsers" :key="user.id">
              <td>
                <input type="checkbox" v-model="selectedUsers" :value="user.id">
              </td>
              <td>{{ user.id }}</td>
              <td>{{ user.name }}</td>
              <td>{{ user.phone }}</td>
              <td>{{ user.email }}</td>
              <td>{{ user.address }}</td>
              <td>
                <button @click="editUser(user.id)" class="edit-button">Edit</button>
              </td>
            </tr>
          </tbody>
        </table>
        <div class="pagination">
          <button @click="prevPage" :disabled="currentPage === 5" class="pagination-info">
            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 320 512" class="icon-left">
              <path d="M9.4 233.4c-12.5 12.5-12.5 32.8 0 45.3l192 192c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L77.3 256 246.6 86.6c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0l-192 192z"/>
            </svg>
            Prev
          </button>
          <span v-for="page in totalPages" :key="page" @click="goToPage(page)"
            :class="{ active: currentPage === page }">{{ page }}</span>
          <button @click="nextPage" :disabled="currentPage === totalPages" class="pagination-info">
            Next
            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 320 512" class="icon-right">
              <path d="M310.6 233.4c12.5 12.5 12.5 32.8 0 45.3l-192 192c-12.5 12.5-32.8 12.5-45.3 0s-12.5-32.8 0-45.3L242.7 256 73.4 86.6c-12.5-12.5-12.5-32.8 0-45.3s32.8-12.5 45.3 0l192 192z"/>
            </svg>
          </button>
        </div>
      </main>
    </div>
    <footer>
      <span>Admin1</span>
      <span>admin@gmail.com</span>
    </footer>
  </div>
</template>

<script>
import axios from 'axios';
export default {
  data() {
    return {
      searchQuery: '',
      currentPage: 1,
      usersPerPage: 5,
      selectAll: false,
      selectedUsers: [],
      users: []
    };
  },
  computed: {
    prevPage() {
      if (this.currentPage > 1) this.currentPage--;
    },
    nextPage() {
      if (this.currentPage < this.totalPages) this.currentPage++;
    },
    paginatedUsers() {
      const start = (this.currentPage - 1) * this.usersPerPage;
      const end = start + this.usersPerPage;
      return this.users.slice(start, end);
    },
    totalPages() {
      return Math.ceil(this.users.length / this.usersPerPage);
    }
  },
  methods: {
    async fetchUsers() {
      const response = await axios.get('/users/allusers');
      this.users = response.data.data;
    },
    deleteUsers() {
      this.users = this.users.filter(user => !this.selectedUsers.includes(user.id));
      this.selectedUsers = [];
      this.selectAll = false;
    },
    createUser() {
      // Handle user creation logic here
    },
    editUser(userId) {
      // Handle user editing logic here
    },
    sortUsers(field) {
      this.users.sort((a, b) => (a[field] > b[field] ? 1 : -1));
    },
    toggleSelectAll() {
      this.selectedUsers = this.selectAll ? this.users.map(user => user.id) : [];
    },
    prevPage() {
      if (this.currentPage > 1) this.currentPage--;
    },
    nextPage() {
      if (this.currentPage < this.totalPages) this.currentPage++;
    }
  },
  mounted() {
    this.fetchUsers();
  }
};
</script>

<style scoped>
.container {
  display: flex;
  justify-content: center;
  align-items: center;
  min-height: 100vh;
  background-color: #f5f5f5;
}

.user-manager {
  width: 100%;
  height: 100%;
  background-color: #fff;
  border-radius: 8px;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
  overflow: hidden;
}

header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 20px;
  background-color: #fff;
  border-bottom: 1px solid #ddd;
}

.logo-container {
  display: flex;
  align-items: center;
}

.logo {
  width: 40px;
  height: 40px;
  border-radius: 50%;
  margin-right: 10px;
}

.search-container {
  display: flex;
  align-items: center;
  position: relative;
}

.search-input {
  padding: 5px 10px;
  border: 1px solid #ddd;
  border-radius: 4px;
}

.search-icon {
  width: 20px;
  height: 20px;
  fill: #666;
  position: absolute;
  right: 10px;
}

.content {
  display: flex;
}

aside {
  width: 200px;
  background-color: #f9f9f9;
  padding: 20px;
  border-right: 1px solid #ddd;
}

aside ul {
  list-style: none;
  padding: 0;
  margin: 0;
}

aside ul li {
  padding: 10px;
  cursor: pointer;
}

aside ul li.active {
  background-color: #ddd;
  font-weight: bold;
}

main {
  flex: 1;
  padding: 20px;
}

h2 {
  margin-top: 0;
}

.actions {
  display: flex;
  justify-content: space-between;
  margin-bottom: 20px;
}

.delete-button {
  background-color: #e74c3c;
  color: #fff;
  border: none;
  padding: 10px 20px;
  border-radius: 4px;
  cursor: pointer;
}

.create-button {
  background-color: #2ecc71;
  color: #fff;
  border: none;
  padding: 10px 20px;
  border-radius: 4px;
  cursor: pointer;
}

table {
  width: 100%;
  border-collapse: collapse;
}

thead th {
  background-color: #f9f9f9;
  padding: 10px;
  text-align: left;
  border-bottom: 2px solid #ddd;
  cursor: pointer;
}

tbody td {
  padding: 10px;
  border-bottom: 1px solid #ddd;
}

.edit-button {
  background-color: #2980b9;
  color: #fff;
  border: none;
  padding: 5px 10px;
  border-radius: 4px;
  cursor: pointer;
}

.pagination {
  display: flex;
  justify-content: center;
  margin-top: 20px;
}

.pagination button {
  background-color: #2980b9;
  color: #fff;
  border: none;
  padding: 10px 20px;
  border-radius: 4px;
  cursor: pointer;
}

.pagination span {
  padding: 10px 20px;
}

footer {
  display: flex;
  justify-content: space-between;
  padding: 20px;
  background-color: #f9f9f9;
  border-top: 1px solid #ddd;
}
</style>
