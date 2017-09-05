# ioctlpus

ioctlpus can be used to call driver IOCTLs with arbitrary inputs (with functionality somewhat similar to Burp Repeater).

Here is an example of an information leak triggered in a sample vulnerable driver:

<p align="center"><img src="https://i.imgur.com/t8Vx9ew.png" /></p>

## Tentative Roadmap

- [x] Create handles using Device Interface GUIDs in addition to symbolic links. [[GIF](https://i.imgur.com/R9WkgHG.gif)]
- [ ] Persist requests to SQLite databases.
- [ ] Apply filters to request history.
- [ ] Integrate Kaitai Struct to define and view buffer structures ([inspired by](https://github.com/kaitai-io/kaitai_struct_webide/wiki/Features)).
- [ ] Develop an API to use the tool headlessly (e.g. for fuzzing).
- [ ] Design a cool logo.

## Similar Tools

- [jerome-pouiller / ioctl](https://github.com/jerome-pouiller/ioctl)
- [xst3nz / ioctlbf](https://code.google.com/archive/p/ioctlbf/)

## Licence

[GPLv3](https://tldrlegal.com/license/gnu-general-public-license-v3-(gpl-3))
