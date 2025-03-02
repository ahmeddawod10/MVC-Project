import { fieldsProxy } from "@serenity-is/corelib";

export interface CartRow {
    Id?: number;
    Userid?: string;
    Productid?: number;
    Count?: number;
    Price?: number;
    ProductidName?: string;
}

export abstract class CartRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Userid';
    static readonly localTextPrefix = 'Conne.Cart';
    static readonly deletePermission = 'Cart';
    static readonly insertPermission = 'Cart';
    static readonly readPermission = 'Cart';
    static readonly updatePermission = 'Cart';

    static readonly Fields = fieldsProxy<CartRow>();
}