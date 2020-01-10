import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private SERVER_URL = "http://localhost:55879/api/customer";
  private SERVER_ORDER_URL = "http://localhost:55879/api/order";

  constructor(private httpClient: HttpClient) { }
  public get(){  
    return this.httpClient.get(this.SERVER_URL);  
  }
  public getCustomerDetails(customerId: any){  
    return this.httpClient.get(this.SERVER_URL + "/" + customerId);  
  }
  public deleteOrder(orderId: any){  
    return this.httpClient.get(this.SERVER_ORDER_URL + "/Delete/" + orderId);  
  }
  
  public getEvent(id: any){  
    return this.httpClient.get(this.SERVER_URL + "/" + id);  
  }
}
