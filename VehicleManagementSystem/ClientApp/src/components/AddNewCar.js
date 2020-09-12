import React, { Component } from 'react';
import Form from 'react-bootstrap/Form';
import Col from 'react-bootstrap/Col';
import Button from 'react-bootstrap/Button';
import './styles/AddNewCar.css'

export class AddNewCar extends Component {

    constructor(props) {
        super(props);

        this.state = {
            make: '',
            model: '',
            bodyType: '',
            engine: '',
            numOfDoors: '',
            numOfWheels: '',
        };

    }

    //handling functions for each input
    handleMake(event) {
        this.setState({ make: event.target.value })
    }

    handleModel(event) {
        this.setState({ model: event.target.value })
    }

    handleBodyType(event) {
        this.setState({ bodyType: event.target.value })
    }

    handleEngine(event) {
        this.setState({ engine: event.target.value })
    }

    handleNumberOfDoors(event) {
        this.setState({ numOfDoors: event.target.value })
    }

    handleNumberOfWheels(event) {
        this.setState({ numOfWheels: event.target.value })
    }

    render() {
        const { make, model, engine,bodyType,numOfDoors, 
            numOfWheels, } = this.state;

        return (
            <div>
                <h3 className='label'>Add a Car</h3>
                <div className = "wrapper">
                <Form as={Col} className='display-grid'>
                    <Form.Row>
                        <Form.Group as={Col} controlId='formMake'>
                            <Form.Control
                                placeholder='Make'
                                value = {make}
                                onChange={this.handleMake.bind(this)}
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formModel'>
                            <Form.Control
                                placeholder='Model'
                                value = {model}
                                onChange={this.handleModel.bind(this)}
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formBodyType'>
                            <Form.Control
                                placeholder='Body type'
                                value={bodyType}
                                onChange={this.handleBodyType.bind(this)}
                            />
                        </Form.Group>
                        </Form.Row>
                        <Form.Row>
                        <Form.Group as={Col} controlId='formEngine'>
                            <Form.Control
                                placeholder='Engine'
                                value={engine}
                                onChange={this.handleEngine.bind(this)}
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formNumOfDoors'>
                            <Form.Control
                                type='number'
                                min='0'
                                max='10'
                                placeholder='Number of doors'
                                value={numOfDoors}
                                onChange={this.handleNumberOfDoors.bind(this)}
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formNumOfWheels'>
                            <Form.Control
                                type='number'
                                min='0'
                                max='10'
                                placeholder='Number of wheels'
                                value={numOfWheels}
                                onChange={this.handleNumberOfWheels.bind(this)}
                            />
                        </Form.Group>
                    </Form.Row>
                    <div className="row justify-content-center">
                    <Button
                        variant='primary'
                        className='button'
                    >
                        Add
                    </Button>
                    </div>
                </Form>
                </div>    
            </div>
        );
    }
}
