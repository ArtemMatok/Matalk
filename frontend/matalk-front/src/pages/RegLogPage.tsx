import 'boxicons/css/boxicons.min.css';
import '../styles/login.css';
import { useEffect } from 'react';

const RegLogPage = () => {
    useEffect(() => {
        const container = document.querySelector('.container');
        const loginLink = document.querySelector('.SignInLink');
        const registerLink = document.querySelector('.SignUpLink');

        if (!container || !loginLink || !registerLink) return;

        const handleRegisterClick = () => {
            container.classList.add('active');
        };

        const handleLoginClick = () => {
            container.classList.remove('active');
        };

        registerLink.addEventListener('click', handleRegisterClick);
        loginLink.addEventListener('click', handleLoginClick);

        return () => {
            registerLink.removeEventListener('click', handleRegisterClick);
            loginLink.removeEventListener('click', handleLoginClick);
        };
    }, []);

    return (
        <div className="container">
            <div className="curved-shape"></div>
            <div className="curved-shape2"></div>

            <div className="form-box Login">
                <h2 className="animation">Login</h2>
                <form action="#">
                    <div className="input-box animation">
                        <input type="text" required />
                        <label>Username</label>
                        <i className='bx bxs-user'></i>
                    </div>
                    <div className="input-box animation">
                        <input type="password" required />
                        <label>Password</label>
                        <i className='bx bxs-lock-alt'></i>
                    </div>
                    <div className="input-box animation">
                        <button className="btn" type="submit">Login</button>
                    </div>
                    <div className="regi-link animation">
                        <p>Don't have an account? <a href='#' className='SignUpLink'>Sign Up</a></p>
                    </div>
                </form>
            </div>

            <div className="info-content Login">
                <h2 className="animation">WELCOME BACK!</h2>
                <p className="animation">Lorem, ipsum dolor sit amet consectetur adipisicing elit.</p>
            </div>

            <div className="form-box Register">
                <h2 className='animation'>Register</h2>
                <form action="#">
                    <div className="input-box animation">
                        <input type="text" required />
                        <label>Username</label>
                        <i className='bx bxs-user'></i>
                    </div>
                    <div className="input-box animation">
                        <input type="password" required />
                        <label>Password</label>
                        <i className='bx bxs-lock-alt'></i>
                    </div>
                    <div className="input-box animation">
                        <button className="btn_register" type="submit">Register</button>
                    </div>
                    <div className="regi-link animation">
                        <p>Already have an account? <a href='#' className='SignInLink'>Sign In</a></p>
                    </div>
                </form>
            </div>

            <div className="info-content Register">
                <h2 className="animation">SIGN UP NOW!</h2>
                <p className="animation">Lorem, ipsum dolor sit amet consectetur adipisicing elit.</p>
            </div>
        </div>
    );
};

export default RegLogPage;