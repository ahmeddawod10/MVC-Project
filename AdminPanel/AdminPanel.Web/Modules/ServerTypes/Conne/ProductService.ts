﻿import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ProductRow } from "./ProductRow";

export namespace ProductService {
    export const baseUrl = 'Conne/Product';

    export declare function Create(request: SaveRequest<ProductRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ProductRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProductRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ProductRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProductRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ProductRow>>;

    export const Methods = {
        Create: "Conne/Product/Create",
        Update: "Conne/Product/Update",
        Delete: "Conne/Product/Delete",
        Retrieve: "Conne/Product/Retrieve",
        List: "Conne/Product/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ProductService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}