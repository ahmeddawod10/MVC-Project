import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CategoryForm {
    Name: StringEditor;
    Description: StringEditor;
    Photo: StringEditor;
}

export class CategoryForm extends PrefixedContext {
    static readonly formKey = 'Conne.Category';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoryForm.init)  {
            CategoryForm.init = true;

            var w0 = StringEditor;

            initFormType(CategoryForm, [
                'Name', w0,
                'Description', w0,
                'Photo', w0
            ]);
        }
    }
}