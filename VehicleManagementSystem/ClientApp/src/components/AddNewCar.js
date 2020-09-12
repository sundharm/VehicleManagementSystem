import React, { Component } from 'react';
import Form from 'react-bootstrap/Form';
import Col from 'react-bootstrap/Col';
import Button from 'react-bootstrap/Button';
import './styles/AddNewCar.css'

export class AddNewCar extends Component {

    render() {
        return (
            <div>
                <h3 className='label'>Add a Car</h3>
                <div className = "wrapper">
                <Form as={Col} className='display-grid'>
                    <Form.Row>
                        <Form.Group as={Col} controlId='formMake'>
                            <Form.Control
                                placeholder='Make'
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formModel'>
                            <Form.Control
                                placeholder='Model'
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formBodyType'>
                            <Form.Control
                                placeholder='Body type'
                            />
                        </Form.Group>
                        </Form.Row>
                        <Form.Row>
                        <Form.Group as={Col} controlId='formEngine'>
                            <Form.Control
                                placeholder='Engine'
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formNumOfDoors'>
                            <Form.Control
                                type='number'
                                min='0'
                                max='10'
                                placeholder='Number of doors'
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formNumOfWheels'>
                            <Form.Control
                                type='number'
                                min='0'
                                max='10'
                                placeholder='Number of wheels'
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
