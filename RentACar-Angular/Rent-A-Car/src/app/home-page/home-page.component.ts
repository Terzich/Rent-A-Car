import { Component, OnInit } from '@angular/core';
import { Car } from '../car-model';
import { CarService } from '../car.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {

carList:Car[];
savedCar:Car;

  constructor(private carService:CarService) { }



  ngOnInit(): void {
    this.carService.getCarsFormServer().subscribe(carsFromServer=> this.carList=carsFromServer);

  }

  carDetails(car:Car):void{
    this.savedCar=car;
  }

}
