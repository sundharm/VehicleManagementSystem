import React, { Component } from 'react';
import { Dropdown, DropdownButton } from 'react-bootstrap';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <React.Fragment>
            <DropdownButton className="drop-down-button" id="dropdown-basic-button" title="Select a vehicle to add">
                <Dropdown.Item className="car">Car</Dropdown.Item>
                <Dropdown.Item className="disabled">Bike</Dropdown.Item>
                <Dropdown.Item className="disabled">Boat</Dropdown.Item>
            </DropdownButton>
        </React.Fragment>
    )
  }
}
