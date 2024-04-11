import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { JatekosComponent } from './jatekos/jatekos.component';

const routes: Routes = [
  {path:"home", component:HomeComponent},
  {path:"jatekos", component:JatekosComponent},
  {path:"", component:HomeComponent},
  {path:"**", component:HomeComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
