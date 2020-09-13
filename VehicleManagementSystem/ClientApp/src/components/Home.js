import React, { Component } from 'react';
import { Redirect } from 'react-router-dom'
import { Dropdown, DropdownButton } from 'react-bootstrap';
import './styles/Home.css'


export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            carSelected: false
        }
    }

    handleCarSelected() {
        this.setState({
            carSelected: true
        })
    }


    render() {
        if (this.state.carSelected) {
            return <Redirect to ="/addNewCar"/>
        }

        return (
            <React.Fragment>
                <DropdownButton className="dropDownBtn" id="dropdown-basic-button" title="Select a vehicle to add">
                    <Dropdown.Item onClick={this.handleCarSelected.bind(this)}>Create car</Dropdown.Item>
                    <Dropdown.Item className="disabled">Create bike</Dropdown.Item>
                    <Dropdown.Item className="disabled">Create boat</Dropdown.Item>
                </DropdownButton>
                <div className="footerMsg">
                    <p>Note:<i> Only cars are supported currently. Other vehicle types will be added in the future.</i></p>
                </div>
            </React.Fragment>
        )
    }
}
