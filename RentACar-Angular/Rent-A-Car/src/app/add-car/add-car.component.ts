import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Car } from '../car-model';
import { CarService } from '../car.service';

@Component({
  selector: 'app-add-car',
  templateUrl: './add-car.component.html',
  styleUrls: ['./add-car.component.scss']
})
export class AddCarComponent implements OnInit {

  message:string;

  constructor(private service:CarService) { }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    
    console.log(form.controls['name'].value);
    let carDomain:Car=
    {
      name:form.controls['name'].value,
      horsePower:form.controls['horsePower'].value,
      numberOfDoors:form.controls['numberOfDoors'].value,
      yearOfProduction:form.controls['yearOfProduction'].value,
      description:form.controls['description'].value,
       color:form.controls['color'].value
      
    }
    console.log(carDomain);

    this.service.saveCar(carDomain).subscribe(result => console.log(result));
    this.message="Uspješno ste dodali automobil";

  }
}
