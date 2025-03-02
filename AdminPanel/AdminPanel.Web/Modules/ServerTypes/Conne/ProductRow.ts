import { fieldsProxy } from "@serenity-is/corelib";

export interface ProductRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Price?: number;
    Catid?: number;
    Photo?: string;
    CatidName?: string;
}

export abstract class ProductRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Conne.Product';
    static readonly deletePermission = 'Product';
    static readonly insertPermission = 'Product';
    static readonly readPermission = 'Product';
    static readonly updatePermission = 'Product';

    static readonly Fields = fieldsProxy<ProductRow>();
}