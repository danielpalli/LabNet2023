import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

    getCategoryData(): any {
        return [
            {
                id: '1000',
                categoryName: 'Bamboo Watch',
                description: 'Product Description',
                image: 'bamboo-watch.jpg',
            },
            {
                id: '1001',
                categoryName: 'Black Watch',
                description: 'Product Description',
                image: 'black-watch.jpg',
            },
            {
                id: '1002',
                categoryName: 'Blue Band',
                description: 'Product Description',
                image: 'blue-band.jpg',
            }
        ];
    }


    getProductsMini() {
        return Promise.resolve(this.getCategoryData().slice(0, 5));
    }

    getProductsSmall() {
        return Promise.resolve(this.getCategoryData().slice(0, 10));
    }

    getProducts() {
        return Promise.resolve(this.getCategoryData());
    }

}
