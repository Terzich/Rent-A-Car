import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCarComponent } from './add-car/add-car.component';
import { CarListComponent } from './car-list/car-list.component';
import { HomePageComponent } from './home-page/home-page.component';

const routes:Routes=[
  {path:'', component:HomePageComponent},
  {path:'listOfCars',component:CarListComponent},
  {path:'addNewCar',component:AddCarComponent}

];
 


@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
