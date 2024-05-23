import Validation from "./Validation";

export default class SignUpValidation{
    constructor(email, password){
    
        this.email = email;
        this.password = password;
    }
    checkValidation(){
        let errors = [];

        if(!Validation.checkEmail(this.email)){
            errors['email'] = 'Invalid email';
        }
        if(!Validation.minLength(this.password, 6)){
            errors['password'] = 'Password must be at least 6 characters';
        }
        return errors;
    }


}