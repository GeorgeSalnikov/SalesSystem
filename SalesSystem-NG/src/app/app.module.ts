import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
//import { HomeComponent } from './home/home.component';
//import { AboutComponent } from './about/about.component';
import { CustomersComponent } from './customers/customers.component';
import { CustomerOrdersComponent } from './customer-orders/customer-orders.component';

import { MatToolbarModule,
  MatIconModule,
  MatCardModule,
  MatButtonModule,
  MatProgressSpinnerModule } from '@angular/material';

@NgModule({
  declarations: [
    AppComponent,
    //HomeComponent,
    //AboutComponent,
    CustomersComponent,
    CustomerOrdersComponent
    //EventsComponent,
    //EventDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    //BrowserAnimationsModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatCardModule,
    MatProgressSpinnerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
