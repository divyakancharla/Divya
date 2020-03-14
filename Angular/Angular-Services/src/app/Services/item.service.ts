import { Injectable } from '@angular/core';
import{HttpClient,HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Item } from '../item';
import { identifierModuleUrl } from '@angular/compiler';
import { Order } from '../order';
const Requestheaders={headers:new HttpHeaders({
  'content-type':'application/json'})

}
@Injectable({
  providedIn: 'root'
})
export class ItemService {
url:string='http://localhost:54147/api/Item/'
urlI:string='http://localhost:57695/api/Order/'
  constructor(private http:HttpClient) { }
  public GetAll():Observable<Item[]>
  {
    return this.http.get<Item[]>(this.url+'get');
  }
  public GetById(id:string):Observable<any>{
    return this.http.get<Item>(this.url+'get/'+id,Requestheaders);
  }
  public Add(item:Item):Observable<any>{
    return this.http.post<any>(this.url+'add',JSON.stringify(item));
  }
  public Update(item:Item):Observable<any>{
    return this.http.put<any>(this.url+'update',JSON.stringify(item),Requestheaders);
  }
  public Delete(id:string):Observable<Item>{
    return this.http.delete<Item>(this.url+'delete/'+id,Requestheaders);
  }
  public add(item:Order):Observable<any>{
    return this.http.post<any>(this.urlI+'add',item);
  }
}
