import React, { Component } from 'react';
import { Container, Navbar, NavbarBrand } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavMenu extends Component {

  render () {
    return (
      <header>
        <Navbar className="border-bottom box-shadow mb-3" light>
          <Container>
            <NavbarBrand tag={Link} to="/">Vehicle Management System</NavbarBrand>
          </Container>
        </Navbar>
      </header>
    );
  }
}
