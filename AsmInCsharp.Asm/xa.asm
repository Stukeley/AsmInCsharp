        includelib      msvcrtd
        ;includelib      oldnames        ;optional
        .data
        .data?
        .code
        public  DllMain
        public  Example

DllMain proc                            ;return true
        mov     rax, 1
        ret     0
DllMain endp

Example proc                            ;[rcx] = 0123456789abcdefh
        mov     rax, 0123456789abcdefh
        mov     [rcx],rax
        ret     0
Example endp
        end