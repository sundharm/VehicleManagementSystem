import React, { Component } from 'react';
import { Redirect } from 'react-router-dom'
import { Dropdown, DropdownButton } from 'react-bootstrap';


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
                <DropdownButton className="drop-down-button" id="dropdown-basic-button" title="Select a vehicle to add">
                    <Dropdown.Item onClick={this.handleCarSelected.bind(this)}>Car</Dropdown.Item>
                    <Dropdown.Item className="disabled">Bike</Dropdown.Item>
                    <Dropdown.Item className="disabled">Boat</Dropdown.Item>
                </DropdownButton>
            </React.Fragment>
        )
    }
}
