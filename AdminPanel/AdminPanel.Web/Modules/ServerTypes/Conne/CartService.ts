﻿import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CartRow } from "./CartRow";

export namespace CartService {
    export const baseUrl = 'Conne/Cart';

    export declare function Create(request: SaveRequest<CartRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CartRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CartRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CartRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CartRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CartRow>>;

    export const Methods = {
        Create: "Conne/Cart/Create",
        Update: "Conne/Cart/Update",
        Delete: "Conne/Cart/Delete",
        Retrieve: "Conne/Cart/Retrieve",
        List: "Conne/Cart/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CartService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}