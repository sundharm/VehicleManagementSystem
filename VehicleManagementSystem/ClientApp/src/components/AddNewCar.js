import React, { Component } from 'react';
import Form from 'react-bootstrap/Form';
import Col from 'react-bootstrap/Col';
import { Button } from 'react-bootstrap';
import { UncontrolledAlert } from 'reactstrap';
import axios from 'axios';
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
            validateError:'',
            showSuccessAlert: false,
            showFailureAlert: false
        };
    }

    //handling function for inputs
    handleChange(event) {
        this.setState({
            [event.target.name] : event.target.value
        });
    }

    //show success alert from server
    handleSuccessResponse(){
        this.clearState();
        this.setState({
            showSuccessAlert: true
        })
    }

    //show error alert from server
    handleFailureResponse() {
        this.setState({
            showFailureAlert: true,
            showSuccessAlert: false
        })
    }

    //function to get the initial state
    clearState(){
        this.setState({
            make: '',
            model: '',
            bodyType: '',
            engine: '',
            numOfDoors: '',
            numOfWheels: '',
            showSuccessAlert: false,
            showFailureAlert: false
        })
    }

    //simple validation to get all inputs from user
    validate() {
        let validateError = "";
        if (this.state.make === "" || this.state.model === ""
        || this.state.engine === "" || this.state.bodyType === ""
        || this.state.numOfDoors === "" || this.state.numOfWheels === "") {
            validateError = "All fields are required!"
        }

        if(validateError){
            this.setState({
                validateError
            })
            return false;
        }
        
        return true;
    }

    //axios to submit data only if valid
    handleSubmit(event) {
        event.preventDefault();
        if(this.validate()){  
            this.setState({
                validateError: "",
            })
            axios.post(process.env.REACT_APP_ADD_CAR_API, 
            {
                type: 'car',
                make: this.state.make,
                model: this.state.model,
                bodyType: this.state.bodyType,
                engine: this.state.engine,
                numOfDoors: this.state.numOfDoors,
                numOfWheels: this.state.numOfWheels
            })
            .then(response=>{
                if(response.status===200){
                    this.handleSuccessResponse();
                }          
            })
            .catch(error=>{
                console.log(error.response.data);
                this.handleFailureResponse();
            })
        }
        
    }

    render() {
        const { make, model, engine,bodyType,numOfDoors, 
            numOfWheels, showSuccessAlert, showFailureAlert } = this.state;

        return (
            <div>   
                <h3 className='label'>Add a Car</h3>
                {
                    showSuccessAlert && 
                    <UncontrolledAlert color="success">
                        Car added successfully!
                    </UncontrolledAlert>
                }
                {
                    showFailureAlert && 
                    <UncontrolledAlert color="danger">
                        Error adding car! Please check your input.
                    </UncontrolledAlert>
                }

                <div className="validateError">{this.state.validateError}</div>
                <div className = "wrapper">
                <Form as={Col} className='displayGrid'>
                    <Form.Row>
                        <Form.Group as={Col} controlId='formMake'>
                            <Form.Control
                                name='make'
                                placeholder='Make'
                                value = {make}
                                onChange={this.handleChange.bind(this)}
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formModel'>
                            <Form.Control
                                name='model'
                                placeholder='Model'
                                value = {model}
                                onChange={this.handleChange.bind(this)}
                            />
                            </Form.Group>

                        <Form.Group as={Col} controlId='formBodyType'>
                            <Form.Control
                                name='bodyType'
                                placeholder='Body type'
                                value={bodyType}
                                onChange={this.handleChange.bind(this)}
                            />
                        </Form.Group>
                        </Form.Row>
                        <Form.Row>
                        <Form.Group as={Col} controlId='formEngine'>
                            <Form.Control
                                name='engine'
                                placeholder='Engine'
                                value={engine}
                                onChange={this.handleChange.bind(this)}
                            />
                        </Form.Group>
                        <Form.Group as={Col} controlId='formNumOfDoors'>
                            <Form.Control
                                as='select'
                                name='numOfDoors'
                                value={numOfDoors}
                                onChange={this.handleChange.bind(this)}
                                >   
                                    <option value="" selected disabled>Number of Doors</option> 
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                    <option>7</option>
                                    <option>8</option>
                            </Form.Control>
                        </Form.Group>
                        <Form.Group as={Col} controlId='formNumOfWheels'>
                            <Form.Control
                                as='select'
                                name='numOfWheels'
                                value={numOfWheels}
                                onChange={this.handleChange.bind(this)}
                                >
                                    <option value="" selected disabled>Number of Wheels</option> 
                                    <option>4</option>
                                    <option>5</option>
                                    <option>6</option>
                                    <option>7</option>
                                    <option>8</option>
                            </Form.Control>
                        </Form.Group>
                    </Form.Row>
                    <div className="row justify-content-center">
                    <Button
                        variant='primary'
                        className='button'
                        onClick={this.handleSubmit.bind(this)}
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
