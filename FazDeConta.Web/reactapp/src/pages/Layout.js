import { Outlet, Link } from "react-router-dom";

const Layout = () => {
    return (
        <div>
            <header>
                <nav>
                    <ul>
                        <li>
                            <Link to="/">Calculadora</Link>
                        </li>
                        <li>
                            <Link to="/about">Sobre mim</Link>
                        </li>
                    </ul>
                </nav>
            </header>
            <main>
                <Outlet />
            </main>
            <footer>
                <p>&copy; { (new Date()).getFullYear() } - Lenerci Junior</p>
            </footer>
        </div>
    );
}

export default Layout;