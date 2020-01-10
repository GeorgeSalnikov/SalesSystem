import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
//import { HomeComponent } from './home/home.component';
//import { AboutComponent } from './about/about.component';
//import { EventsComponent } from './events/events.component';
//import { EventDetailsComponent } from './event-details/event-details.component';
import { CustomersComponent } from './customers/customers.component';
import { CustomerOrdersComponent } from './customer-orders/customer-orders.component';


const routes: Routes = [
  { path: '', redirectTo: 'customers', pathMatch: 'full'},
//  { path: 'home', component: HomeComponent },
//  { path: 'about', component: AboutComponent },
//  { path: 'events', component: EventsComponent },
//{ path: 'events/:id', component: EventDetailsComponent },
{ path: 'customers', component: CustomersComponent },
{ path: 'customers/:id', component: CustomerOrdersComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
