import { StringEditor, DecimalEditor, ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ProductForm {
    Name: StringEditor;
    Description: StringEditor;
    Price: DecimalEditor;
    Catid: ServiceLookupEditor;
    Photo: StringEditor;
}

export class ProductForm extends PrefixedContext {
    static readonly formKey = 'Conne.Product';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductForm.init)  {
            ProductForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = ServiceLookupEditor;

            initFormType(ProductForm, [
                'Name', w0,
                'Description', w0,
                'Price', w1,
                'Catid', w2,
                'Photo', w0
            ]);
        }
    }
}